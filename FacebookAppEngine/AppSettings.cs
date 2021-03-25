using System.IO;
using System.Xml.Serialization;

namespace FacebookAppEngine
{
    public class AppSettings
    {
        private static string s_AppSettingsFilePath = Directory.GetCurrentDirectory() + "\\AppSettings.xml";

        public string AccessToken { get; set; }

        public bool RememberMe { get; set; }

        public static AppSettings GetLastAppSettingsOrDefault()
        {
            AppSettings returnedAppSettings = new AppSettings();
            verifyAppSettingsFileExists();

            if (new FileInfo(s_AppSettingsFilePath).Length != 0)
            {
                using (Stream stream = new FileStream(s_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    returnedAppSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return returnedAppSettings;
        }

        private AppSettings()
        {
            AccessToken = null;
            RememberMe = false;
        }

        public void SaveSettingsToFile()
        {
            verifyAppSettingsFileExists();

            using (Stream stream = new FileStream(s_AppSettingsFilePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        private static void verifyAppSettingsFileExists()
        {
            if (!File.Exists(s_AppSettingsFilePath))
            {
                File.Create(s_AppSettingsFilePath);
            }
        }
    }
}