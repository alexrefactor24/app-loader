using CrediTVInstaller.handler;
using System.Linq;
using System.Net;

namespace CrediTVInstaller
{
    public partial class SetupForm : Form
    {

        private AdbHandler adbHandler;
        private readonly string PACKAGE = "co.refactorstudio.creditv";
        private readonly string RECEIVER = "AppDeviceAdminReceiver";
        private readonly string ADB_SUCCESS_MESSAGE = "SUCCESS";

        public SetupForm()
        {
            InitializeComponent();
            adbHandler = new AdbHandler();
            ipText.ValidatingType = typeof(System.Net.IPAddress);
            ipText.ResetOnSpace = false;
            installButton.Enabled = false;
            deviceOwnerButton.Enabled = false;
            packageText.Text = PACKAGE;
            receptorText.Text = RECEIVER;
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            devicesText.Text = String.Empty;
            string devices = adbHandler.GetDeviceList();
            devicesText.Text = devices;
            listCheck.Checked = true;
        }

        private readonly string ERROR_EMPTY_MESSAGE = "Ingrese la dirección IP.";
        private void connectButton_Click(object sender, EventArgs e)
        {
            if (ipText.Text == string.Empty)
                emptyErrorProvider.SetError(ipText, ERROR_EMPTY_MESSAGE);
            else
            {
                logText.Text = String.Empty;
                String log = adbHandler.ConnectDevice(ipText.Text);
                logText.Text = log;
                connectCheck.Checked = true;
            }
        }

        private void apkLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WebClient apkWebClient = new WebClient();
            apkWebClient.DownloadFile("http://mysite.com/myfile.txt", @"d:\myfile.txt");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (apkOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                apkText.Text = apkOpenFileDialog.FileName;
                installButton.Enabled = true;
                searchCheck.Checked = true;
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            string apkFileName = apkText.Text;
            string log = adbHandler.InstallApk(apkFileName);

            if (log.ToUpper().Contains(ADB_SUCCESS_MESSAGE))
            {
                deviceOwnerButton.Enabled = true;
                installCheck.Checked = true;
            }

            logText.Text = log;
        }


        private void DeviceOwnerButton_Click(object sender, EventArgs e)
        {
            deviceOwnerCheck.Checked = true;
            string log = adbHandler.SetDeviceOwner(PACKAGE, RECEIVER);
            logText.Text = log;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            listCheck.Checked = false;
            connectCheck.Checked = false;
            searchCheck.Checked = false;
            installCheck.Checked = false;
            deviceOwnerCheck.Checked = false;
            //
            devicesText.Text = string.Empty;
            ipText.Text = string.Empty;
            apkText.Text = string.Empty;
            logText.Text = string.Empty;
            //
            installButton.Enabled = false;
            deviceOwnerButton.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SetupForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            string apps = adbHandler.GetAppList();
            textBox1.Text = apps;
            listCheck.Checked = true;
        }

        private void devicesText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}