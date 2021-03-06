﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Xml;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;

namespace Sdl.Community.DeepLMTProvider
{
	[ApplicationInitializer]
	public class DeeplApplicationInitializer : IApplicationInitializer
	{
		public static HttpClient Clinet = new HttpClient();

		public void Execute()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
			Clinet.Timeout = TimeSpan.FromMinutes(5);
			var pluginVersion = GetPluginVersion();
			Clinet.DefaultRequestHeaders.Add("Trace-ID", $"SDL Trados Studio 2021 /plugin {pluginVersion}");
		}

		private string GetPluginVersion()
		{
			try
			{
				// fetch the version of the plugin from the manifest deployed
				var pexecutingAsseblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
				pexecutingAsseblyPath = Path.Combine(pexecutingAsseblyPath, "pluginpackage.manifest.xml");
				var doc = new XmlDocument();
				doc.Load(pexecutingAsseblyPath);

				if (doc.DocumentElement?.ChildNodes != null)
				{
					foreach (XmlNode n in doc.DocumentElement.ChildNodes)
					{
						if (n.Name == "Version")
						{
							return n.InnerText;
						}
					}
				}
			}
			catch (Exception e)
			{
				// broad catch here, if anything goes wrong with determining the version we don't want the user to be disturbed in any way
			}
			return string.Empty;
		}
	}
}
