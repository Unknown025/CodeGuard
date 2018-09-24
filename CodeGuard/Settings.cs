using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGuard
{
    class Settings
    {
        private static readonly string appdataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CodeGuard\\";
        private static string javaPath = null;
        private static bool useMoss = false;

        public static void LoadSettings()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(appdataDir + "settings.ini");
            data.TryGetKey("javaPath", out javaPath);
            data.TryGetKey("useMoss", out string _useMoss);
            if(_useMoss != null)
                bool.TryParse(_useMoss, out useMoss);
        }

        /// <summary>
        /// Returns the Java path.
        /// </summary>
        public string JavaPath
        {
            get { return javaPath; }
        }
    }
}
