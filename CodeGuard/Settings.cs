using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeGuard
{
    class Settings
    {
        private static readonly string appdataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CodeGuard\\";
        private static readonly string filename = appdataDir + "settings.ini";
        private static string javaPath = null;
        private static bool useMoss = false;
        private static bool enableTimeout = false;

        public static void LoadSettings()
        {            
            var parser = new FileIniDataParser();
            if (!Directory.Exists(appdataDir))
                Directory.CreateDirectory(appdataDir);
            if (!File.Exists(filename))
            {
                IniData iniData = new IniData();
                iniData.Global.AddKey("javaPath", "");
                iniData.Global.AddKey("useMoss", useMoss.ToString());
                iniData.Global.AddKey("enableTimeout", enableTimeout.ToString());
                parser.WriteFile(filename, iniData);
            }
            IniData data = parser.ReadFile(filename);
            data.TryGetKey("javaPath", out javaPath);
            data.TryGetKey("useMoss", out string _useMoss);
            data.TryGetKey("enableTimeout", out string _enableTimeout);
            if (_useMoss != null)
                bool.TryParse(_useMoss, out useMoss);
            if (_enableTimeout != null)
                bool.TryParse(_enableTimeout, out enableTimeout);
        }

        /// <summary>
        /// Returns the Java path.
        /// </summary>
        public static string JavaPath
        {
            get { return javaPath; }
            set { javaPath = value; SaveSettings(); }
        }

        /// <summary>
        /// Returns the setting for MOSS.
        /// </summary>
        public static bool UseMoss
        {
            get { return useMoss; }
            set { useMoss = value; SaveSettings(); }
        }

        public static bool EnableTimeout
        {
            get { return enableTimeout; }
            set { enableTimeout = value; SaveSettings(); }
        }

        public static void SaveSettings()
        {
            var parser = new FileIniDataParser();
            IniData iniData = new IniData();
            SectionData sectionData = new SectionData("General");
            sectionData.Keys.AddKey("javaPath", javaPath);
            sectionData.Keys.AddKey("useMoss", useMoss.ToString());
            sectionData.Keys.AddKey("enableTimeout", enableTimeout.ToString());
            iniData.Sections.Add(sectionData);
            parser.WriteFile(filename, iniData);
        }
    }
}
