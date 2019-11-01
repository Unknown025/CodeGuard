using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CodeGuard_Updater
{
    public partial class UpdateWindow : Form
    {
        private readonly string installPath = Environment.ExpandEnvironmentVariables("%AppData%\\CodeGuard\\CodeGuard.exe");
        private const string downloadUrl = "https://rainyville.heliohost.org/CodeGuard/CodeGuard.exe";

        public UpdateWindow()
        {
            InitializeComponent();
        }

        private void UpdateWindow_Load(object sender, EventArgs ev)
        {
            //XmlUpdate _update = new XmlUpdate
            //{
            //    LatestVersion = new Version(1, 0, 0, 0).ToString()
            //};
            //XmlSerializer serializer = new XmlSerializer(typeof(XmlUpdate));
            //using(TextWriter writer = new StreamWriter("CodeGuard.xml"))
            //{
            //    serializer.Serialize(writer, _update);                
            //}

            Directory.CreateDirectory(Path.GetDirectoryName(installPath));
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CodeGuard Updater\");
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\CodeGuard Updater\", true);
            key.SetValue("UpdaterVersion", Application.ProductVersion);
            key.SetValue("", Assembly.GetExecutingAssembly().Location);
            Version.TryParse((string)key.GetValue("InstalledVersion"), out Version installedVersion);
            if (installedVersion == null)
            {
                key.SetValue("InstalledVersion", new Version(0, 0, 0, 0));
            }            
            SynchronizationContext _context = SynchronizationContext.Current;

            new Thread(() =>
            {
                using (WebClient client = new WebClient())
                {
                    Stream stream = client.OpenRead("https://rainyville.heliohost.org/CodeGuard.xml");
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlUpdate));
                    XmlUpdate update = (XmlUpdate)xmlSerializer.Deserialize(stream);
                    if (Version.Parse(update.LatestVersion) != installedVersion)
                    {
                        client.UploadProgressChanged += (s, e) =>
                        {
                            _context.Post(o =>
                            {
                                progressBar.Maximum = (int)e.TotalBytesToReceive;
                                progressBar.Value = (int)e.BytesReceived;
                            }, null);
                        };
                        client.DownloadFileAsync(new Uri(downloadUrl), installPath);
                        while (client.IsBusy) { Thread.Sleep(500); }
                        key.SetValue("InstalledVersion", update.LatestVersion);
                    }
                    Process.Start(installPath);
                    key.Close();
                    Environment.Exit(0);
                }
            }).Start();            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
