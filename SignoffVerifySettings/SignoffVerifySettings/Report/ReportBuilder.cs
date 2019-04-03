﻿using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Sdl.Community.SignoffVerifySettings.Business.Helpers;
using Sdl.Community.SignoffVerifySettings.DAL;
using Sdl.Community.SignoffVerifySettings.Model;
using Sdl.Core.Globalization;

namespace Sdl.Community.SignoffVerifySettings.Report
{
	public class ReportBuilder
	{
		#region Private Fields
		private readonly XElement _root = new XElement("Report");
		private readonly Utils _utils;
		#endregion

		#region Constructor
		public ReportBuilder()
		{
			_utils = new Utils();
		}
		#endregion

		#region Public Methods
		public string GetReport()
		{
			return _root.ToString();
		}

		/// <summary>
		/// Build the .xml which is used to display information in the .xsl report 
		/// </summary>
		/// <param name="projectInfoReportModel"></param>
		public void BuildTotalReport(ProjectInfoReportModel projectInfoReportModel)
		{
			var parent = new XElement(Constants.ProjectInformation);
			BuildProjectInfoPart(parent, projectInfoReportModel);
			BuildFileInfoPart(parent, projectInfoReportModel);
			BuildQAVerificationSettings(parent, projectInfoReportModel);

			_root.Add(parent);

			// Save information to DB
			//var repository = new SignoffVerifySettingsRepository();
			//repository.SaveProjectInformation(projectInfoReportModel);
		}
		#endregion

		#region Private Methods
		/// <summary>
		/// Generate the xml for the .xsl report which contains the project information
		/// </summary>
		/// <param name="parent">'ProjectInformation' element</param>
		/// <param name="projectInfoReportModel">projectInfoReportModel which contains info from .sdlproj</param>
		private void BuildProjectInfoPart(XElement parent, ProjectInfoReportModel projectInfoReportModel)
		{
			parent.Add(new XElement(Constants.Project,
				new XAttribute("Image", _utils.GetImagesUrl()),
				new XAttribute(Constants.Name, projectInfoReportModel.ProjectName),
				new XAttribute(Constants.StudioVersion, projectInfoReportModel.StudioVersion)));
			parent.Add(new XElement(Constants.SourceLanguage, new XAttribute(Constants.DisplayName, projectInfoReportModel.SourceLanguage.DisplayName)));

			var targetLanguages = new XElement(Constants.TargetLanguages);
			parent.Add(targetLanguages);
			foreach (var targetLanguage in projectInfoReportModel.TargetLanguages)
			{
				targetLanguages.Add(new XElement(Constants.TargetLanguage, new XElement(Constants.DisplayName, targetLanguage.DisplayName)));
			}

			var runAtValue = !string.IsNullOrEmpty(projectInfoReportModel.RunAt) ? projectInfoReportModel.RunAt : Constants.NoVerificationRun;
			parent.Add(new XElement(Constants.RunAt, runAtValue));

			var translationMemories = new XElement(Constants.TranslationMemories);
			parent.Add(translationMemories);
			if (projectInfoReportModel.TranslationMemories.Count == 0)
			{
				translationMemories.Add(new XElement(Constants.TranslationMemory, new XElement(Constants.Name, Constants.NoTranslationMemory)));
			}
			else
			{
				foreach (var translationMemory in projectInfoReportModel.TranslationMemories)
				{
					var fileName = Path.GetFileName(translationMemory.MainTranslationProvider.Uri.LocalPath);
					translationMemories.Add(new XElement(Constants.TranslationMemory, new XElement(Constants.Name, fileName)));
				}
			}

			var termbases = new XElement(Constants.Termbases);
			parent.Add(termbases);
			if (projectInfoReportModel.Termbases.Count == 0)
			{
				termbases.Add(new XElement(Constants.Termbase, new XElement(Constants.Name, Constants.NoTermbase)));
			}
			else
			{
				foreach (var termbase in projectInfoReportModel.Termbases)
				{
					termbases.Add(new XElement(Constants.Termbase, new XElement(Constants.Name, termbase.Name)));
				}
			}

			var checkRegExValue = projectInfoReportModel.CheckRegexRules.Equals(Constants.True) ? Constants.Enabled : Constants.Disabled;
			parent.Add(new XElement(Constants.CheckRegEx, checkRegExValue));

			parent.Add(new XElement(Constants.QAChecker, projectInfoReportModel.QACheckerRanResult));
		}

		/// <summary>
		/// Generate the xml for the .xsl report which contains information for each target file
		/// </summary>
		/// <param name="parent">'ProjectInformation' element</param>
		/// <param name="projectInfoReportModel">projectInfoReportModel which contains info from .sdlproj</param>
		private void BuildFileInfoPart(XElement parent, ProjectInfoReportModel projectInfoReportModel)
		{
			var languageFiles = new XElement(Constants.LanguageFiles);
			parent.Add(languageFiles);

			foreach (var file in projectInfoReportModel.LanguageFileXmlNodeModels)
			{
				// set xml info for basic file information
				var targetLanguage = new Language(file.LanguageCode).DisplayName;
				var runAtValue = !string.IsNullOrEmpty(file.RunAt) ? file.RunAt : Constants.NoVerificationRun;
				var languageFile = new XElement(Constants.LanguageFile);
				languageFile.Add(new XAttribute(Constants.Name, file.FileName),
									new XAttribute(Constants.TargetLanguage, targetLanguage),
									new XAttribute(Constants.RunAt, runAtValue));
				languageFiles.Add(languageFile);
				
				// Set xml info for file phase
				var phaseInfo = projectInfoReportModel.PhaseXmlNodeModels
					.Where(p => p.TargetFileGuid.Equals(file.LanguageFileGuid) && p.IsCurrentAssignment.Equals(Constants.True)).FirstOrDefault();
				var phase = new XElement(Constants.Phase);
				languageFile.Add(phase);
				if (phaseInfo != null)
				{
					phase.Add(new XAttribute(Constants.AssignedPhase, phaseInfo.PhaseName.Split('_').Last()),
								 new XAttribute(Constants.IsCurrentAssignment, phaseInfo.IsCurrentAssignment),
								 new XAttribute(Constants.AssigneesNumber, phaseInfo.AssigneesNumber.ToString()));
				}
				else
				{
					phase.Add(new XAttribute(Constants.AssignedPhase, Constants.NoPhaseAssigned),
						new XAttribute(Constants.IsCurrentAssignment, Constants.False),
						new XAttribute(Constants.AssigneesNumber, Constants.NoUserAssigned));
				}

				// set xml info for file Number Verifier execution
				var numberVerifier = new XElement(Constants.NumberVerifier);
				languageFile.Add(numberVerifier);
				if (projectInfoReportModel.NumberVerifierSettingsModels != null)
				{
					var numberVerifierInfo = projectInfoReportModel.NumberVerifierSettingsModels
						.Where(n => n.FileName.Equals(file.FileName) && n.TargetLanguageCode.Equals(file.LanguageCode)).FirstOrDefault();
					if (numberVerifierInfo != null)
					{
						var value = $"Number Verifier, version {numberVerifierInfo.ApplicationVersion} run at: {numberVerifierInfo.ExecutedDateTime}";
						numberVerifier.Add(new XAttribute(Constants.ExecutedDate, value));
					}
					else
					{
						numberVerifier.Add(new XAttribute(Constants.ExecutedDate, Constants.NoNumberVerifierExecuted));
					}
				}
				else
				{
					numberVerifier.Add(new XAttribute(Constants.ExecutedDate, Constants.NoNumberVerifierExecuted));
				}
			}
		}

		/// <summary>
		/// Set xml info for the QA Verification Settings which are enabled
		/// </summary>
		/// <param name="parent">'ProjectInformation' element</param>
		/// <param name="projectInfoReportModel">projectInfoReportModel which contains info from .sdlproj</param>
		private void BuildQAVerificationSettings(XElement parent, ProjectInfoReportModel projectInfoReportModel)
		{
			var qaVerSettingsElement = new XElement(Constants.VerificationSettings);
			parent.Add(qaVerSettingsElement);

			if (projectInfoReportModel.QAVerificationSettingsModels != null)
			{
				var qaVerificationSettings = projectInfoReportModel
					.QAVerificationSettingsModels.Where(q => q.Value != Constants.False)
					.ToList();
				if (qaVerificationSettings.Any())
				{
					var results = qaVerificationSettings.GroupBy(q => q.LanguagePair).ToList();

					foreach (var result in results)
					{
						var qaRules = new StringBuilder();
						foreach (var res in result)
						{
							// Ignore the duplicates, ignore QA Verificaiton settings which contains 'Count' word (represents the number of applied rules).
							// Ignore RegExRules because will be retrieved and displayed separatly.
							if (!qaRules.ToString().Contains(res.Name) && !res.Name.Contains(Constants.Count) && !res.Name.Contains(Constants.RegExRules))
							{
								// use string builder because it is more faster inside of a foreach
								qaRules.Append($"{res.Name}; ");
							}
						}
						var qaVerSettingElement = new XElement(Constants.VerificationSetting);
						qaVerSettingElement.Add(new XAttribute(Constants.LanguagePair, result.Key),
												new XAttribute(Constants.QASettingName, qaRules.ToString().TrimEnd(' ').TrimEnd(';')));
						qaVerSettingsElement.Add(qaVerSettingElement);
					}
				}
				else
				{
					SetNoQAVerificationSettings(qaVerSettingsElement);
				}
			}
			else
			{
				SetNoQAVerificationSettings(qaVerSettingsElement);
			}
		}

		/// <summary>
		/// Set the XML element when no QA Verification Settings are found
		/// </summary>
		/// <param name="qaVerSettingsElement"></param>
		private void SetNoQAVerificationSettings(XElement qaVerSettingsElement)
		{
			var qaVerSettingElement = new XElement(Constants.VerificationSetting);
			qaVerSettingElement.Add(new XAttribute(Constants.LanguagePair, string.Empty));
			qaVerSettingElement.Add(new XAttribute(Constants.QASettingName, Constants.NoQAVerificationSettings));
			qaVerSettingsElement.Add(qaVerSettingElement);
		}
		#endregion
	}
}