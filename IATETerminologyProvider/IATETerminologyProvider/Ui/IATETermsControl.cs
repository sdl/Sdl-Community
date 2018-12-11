﻿using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using IATETerminologyProvider.Helpers;
using Sdl.Terminology.TerminologyProvider.Core;

namespace IATETerminologyProvider.Ui
{
	public partial class IATETermsControl : UserControl
	{
		#region Private Fields
		private readonly IATETerminologyProvider _iateTerminologyProvider;
		#endregion

		#region Constructors
		public IATETermsControl()
		{
			InitializeComponent();
		}

		public IATETermsControl(IATETerminologyProvider iateTerminologyProvider) : this()
		{
			ShowFields();
			_iateTerminologyProvider = iateTerminologyProvider;
		}
		#endregion

		#region Public Methods
		public void JumpToTerm(IEntry entry)
		{
			var languageFlags = new LanguageFlags();
			var entryLanguage = entry.Languages[1];

			//get the entry by Id from all the terms result and map the following values from the target language
			if (entryLanguage != null)
			{
				pictureBox1.Load(languageFlags.GetImageStudioCodeByLanguageCode(entryLanguage.Locale.Name));
				lblLanguageText.Text = entryLanguage.Name;
				var terms = entryLanguage.Terms;
				if (terms.Count > 0)
				{
					lblTermText.Text = Utils.UppercaseFirstLetter(terms[0].Value);

					txtDefinitionText.Text = terms[0].Fields.Where(f => f.Name.Equals("Definition")).FirstOrDefault() != null
						? Utils.UppercaseFirstLetter(terms[0].Fields.Where(f => f.Name.Equals("Definition")).FirstOrDefault().Value)
						: string.Empty;

					lblDomainText.Text = terms[0].Fields.Where(f => f.Name.Equals("Domain")).FirstOrDefault() != null
						? Utils.UppercaseFirstLetter(terms[0].Fields.Where(f => f.Name.Equals("Domain")).FirstOrDefault().Value.ToLower())
						: string.Empty;

					lblSubdomainText.Text = terms[0].Fields.Where(f => f.Name.Equals("Subdomain")).FirstOrDefault() != null
						? terms[0].Fields.Where(f => f.Name.Equals("Subdomain")).FirstOrDefault().Value
						: string.Empty;
					lblSubdomainText.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lblSubdomainText.Text.ToLower());

					lblTermTypeText.Text = terms[0].Fields.Where(f => f.Name.Equals("TermType")).FirstOrDefault() != null
						? Utils.UppercaseFirstLetter(terms[0].Fields.Where(f => f.Name.Equals("TermType")).FirstOrDefault().Value)
						: string.Empty;
				}
				ShowFields();
			}
		}
		#endregion

		#region Private Methods
		private void ShowFields()
		{
			lblLanguageText.Visible = !string.IsNullOrEmpty(lblLanguageText.Text) ? true : false;
			lblTerm.Visible = !string.IsNullOrEmpty(lblTermText.Text) ? true : false;
			lblDefinition.Visible = !string.IsNullOrEmpty(txtDefinitionText.Text) ? true : false;
			txtDefinitionText.Visible = !string.IsNullOrEmpty(txtDefinitionText.Text) ? true : false;
			lblDomain.Visible = !string.IsNullOrEmpty(lblDomainText.Text) ? true : false;
			lblSubDomain.Visible  = !string.IsNullOrEmpty(lblSubdomainText.Text) ? true : false;
			lblTermType.Visible = !string.IsNullOrEmpty(lblTermTypeText.Text) ? true : false;
		}
		#endregion
	}
}