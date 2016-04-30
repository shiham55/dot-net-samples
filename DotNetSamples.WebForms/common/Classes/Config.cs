using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DotNetSample.WebForms.BaseClasses
{
	public class Config
	{
		#region Properties
		public static string ApplicationUrl
		{
			get
			{
				return GetAppSettingString("ApplicationUrl");
			}
		}
		#endregion

		#region App Setting Methods

		protected static string GetAppSettingString(string Key)
		{
			NameValueCollection appSettings = WebConfigurationManager.AppSettings;

			string setting = appSettings[Key];

			// Check for null and log an error
			
			return setting;
		}

		protected static bool GetAppSettingBoolean(string key)
		{
			string text = GetAppSettingString(key);

			bool setting = Boolean.Parse(text);

			return setting;
		}

		static int GetIntegerSetting(string key)
		{
			string text = GetAppSettingString(key);

			int setting = Int32.Parse(text);

			return setting;
		}

		#endregion
	}
}