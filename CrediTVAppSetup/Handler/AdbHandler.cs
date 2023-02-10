using CrediTVAppSetup.Util;
using System.Diagnostics;
using System.IO.Compression;
using System.Reflection;

namespace CrediTVInstaller.handler
{
    public class AdbHandler
    {
        private string fileName;
        private string arguments;
        private string workingDirectory;
        private bool createNoWindow;
        private bool useShellExecute;
        public AdbHandler()
        {
            fileName = @"c:\adb\adb.exe";
            arguments = "";
            workingDirectory = ".";
            createNoWindow = false;
            useShellExecute = false;

            InitAdbResource();
        }


        private void InitAdbResource()
        {
            string adbFile = fileName;

            if (!File.Exists(adbFile))
            {
                string zipFile = @"adb.zip";
                string resourceName = @"CrediTVAppSetup.Resources." + zipFile;
                string tempPath = @"C:\temp";
                string zipPath = Path.Combine(tempPath, zipFile);
                string extractPath = @"C:\";

                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                if (!Directory.Exists(extractPath))
                    Directory.CreateDirectory(extractPath);

                ResourceReader.CreateFileFromResource(resourceName, tempPath, zipFile);

                ZipFile.ExtractToDirectory(zipPath, extractPath);
            }
        }

        public string ConnectDevice(string ipAddress)
        {
            arguments = @"connect " + ipAddress;
            return ExecuteAdbCommand();
        }

        public string GetDeviceList()
        {
            arguments = @"devices";
            return ExecuteAdbCommand();
        }

        public string InstallApk(string apkFileName)
        {
            arguments = @"install -r " + apkFileName;
            return ExecuteAdbCommand();
        }

        public string SetDeviceOwner(string package, string receiver)
        {
            useShellExecute = false;
            arguments = @"dpm set-device-owner " + package + "/" + package + "." + receiver;
            return ExecuteAdbCommand();
        }
        private string ExecuteAdbCommand()
        {
            using Process cmd = new()
            {
                StartInfo =
                {
                    FileName = fileName,
                    Arguments = arguments,
                    WorkingDirectory = workingDirectory,
                    CreateNoWindow = createNoWindow,
                    UseShellExecute = useShellExecute,
                    RedirectStandardInput=true,
                    RedirectStandardOutput = true
                }
            };

            cmd.Start();
            string output = "";
            while (!cmd.HasExited)
                output += cmd.StandardOutput.ReadToEnd();

            return output;
        }


    }

}
