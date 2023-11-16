namespace CrediTVInstaller
{
    partial class SetupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            devicesText = new TextBox();
            connectButton = new Button();
            ipText = new MaskedTextBox();
            apkLink = new LinkLabel();
            receptorText = new TextBox();
            searchButton = new Button();
            listButton = new Button();
            apkText = new TextBox();
            ipLabel = new Label();
            packageText = new TextBox();
            apkOpenFileDialog = new OpenFileDialog();
            installButton = new Button();
            cancelButton = new Button();
            emptyErrorProvider = new ErrorProvider(components);
            deviceOwnerButton = new Button();
            panel1 = new Panel();
            connectCheck = new CheckBox();
            deviceOwnerCheck = new CheckBox();
            installCheck = new CheckBox();
            searchCheck = new CheckBox();
            listCheck = new CheckBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            logText = new TextBox();
            newButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emptyErrorProvider).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(devicesText);
            groupBox1.Controls.Add(connectButton);
            groupBox1.Controls.Add(ipText);
            groupBox1.Controls.Add(apkLink);
            groupBox1.Controls.Add(receptorText);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(listButton);
            groupBox1.Controls.Add(apkText);
            groupBox1.Controls.Add(ipLabel);
            emptyErrorProvider.SetError(groupBox1, resources.GetString("groupBox1.Error"));
            emptyErrorProvider.SetIconAlignment(groupBox1, (ErrorIconAlignment)resources.GetObject("groupBox1.IconAlignment"));
            emptyErrorProvider.SetIconPadding(groupBox1, (int)resources.GetObject("groupBox1.IconPadding"));
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            toolTip1.SetToolTip(groupBox1, resources.GetString("groupBox1.ToolTip"));
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            emptyErrorProvider.SetError(label1, resources.GetString("label1.Error"));
            emptyErrorProvider.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            emptyErrorProvider.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            emptyErrorProvider.SetError(textBox1, resources.GetString("textBox1.Error"));
            emptyErrorProvider.SetIconAlignment(textBox1, (ErrorIconAlignment)resources.GetObject("textBox1.IconAlignment"));
            emptyErrorProvider.SetIconPadding(textBox1, (int)resources.GetObject("textBox1.IconPadding"));
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            toolTip1.SetToolTip(textBox1, resources.GetString("textBox1.ToolTip"));
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            emptyErrorProvider.SetError(button1, resources.GetString("button1.Error"));
            emptyErrorProvider.SetIconAlignment(button1, (ErrorIconAlignment)resources.GetObject("button1.IconAlignment"));
            emptyErrorProvider.SetIconPadding(button1, (int)resources.GetObject("button1.IconPadding"));
            button1.Name = "button1";
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            emptyErrorProvider.SetError(label5, resources.GetString("label5.Error"));
            emptyErrorProvider.SetIconAlignment(label5, (ErrorIconAlignment)resources.GetObject("label5.IconAlignment"));
            emptyErrorProvider.SetIconPadding(label5, (int)resources.GetObject("label5.IconPadding"));
            label5.Name = "label5";
            toolTip1.SetToolTip(label5, resources.GetString("label5.ToolTip"));
            // 
            // devicesText
            // 
            resources.ApplyResources(devicesText, "devicesText");
            devicesText.BackColor = SystemColors.Window;
            devicesText.BorderStyle = BorderStyle.None;
            emptyErrorProvider.SetError(devicesText, resources.GetString("devicesText.Error"));
            emptyErrorProvider.SetIconAlignment(devicesText, (ErrorIconAlignment)resources.GetObject("devicesText.IconAlignment"));
            emptyErrorProvider.SetIconPadding(devicesText, (int)resources.GetObject("devicesText.IconPadding"));
            devicesText.Name = "devicesText";
            devicesText.ReadOnly = true;
            toolTip1.SetToolTip(devicesText, resources.GetString("devicesText.ToolTip"));
            devicesText.TextChanged += devicesText_TextChanged;
            // 
            // connectButton
            // 
            resources.ApplyResources(connectButton, "connectButton");
            emptyErrorProvider.SetError(connectButton, resources.GetString("connectButton.Error"));
            emptyErrorProvider.SetIconAlignment(connectButton, (ErrorIconAlignment)resources.GetObject("connectButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(connectButton, (int)resources.GetObject("connectButton.IconPadding"));
            connectButton.Name = "connectButton";
            toolTip1.SetToolTip(connectButton, resources.GetString("connectButton.ToolTip"));
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // ipText
            // 
            resources.ApplyResources(ipText, "ipText");
            emptyErrorProvider.SetError(ipText, resources.GetString("ipText.Error"));
            emptyErrorProvider.SetIconAlignment(ipText, (ErrorIconAlignment)resources.GetObject("ipText.IconAlignment"));
            emptyErrorProvider.SetIconPadding(ipText, (int)resources.GetObject("ipText.IconPadding"));
            ipText.Name = "ipText";
            toolTip1.SetToolTip(ipText, resources.GetString("ipText.ToolTip"));
            // 
            // apkLink
            // 
            resources.ApplyResources(apkLink, "apkLink");
            emptyErrorProvider.SetError(apkLink, resources.GetString("apkLink.Error"));
            emptyErrorProvider.SetIconAlignment(apkLink, (ErrorIconAlignment)resources.GetObject("apkLink.IconAlignment"));
            emptyErrorProvider.SetIconPadding(apkLink, (int)resources.GetObject("apkLink.IconPadding"));
            apkLink.Name = "apkLink";
            apkLink.TabStop = true;
            toolTip1.SetToolTip(apkLink, resources.GetString("apkLink.ToolTip"));
            apkLink.LinkClicked += apkLink_LinkClicked;
            // 
            // receptorText
            // 
            resources.ApplyResources(receptorText, "receptorText");
            receptorText.BackColor = SystemColors.Window;
            receptorText.BorderStyle = BorderStyle.None;
            emptyErrorProvider.SetError(receptorText, resources.GetString("receptorText.Error"));
            emptyErrorProvider.SetIconAlignment(receptorText, (ErrorIconAlignment)resources.GetObject("receptorText.IconAlignment"));
            emptyErrorProvider.SetIconPadding(receptorText, (int)resources.GetObject("receptorText.IconPadding"));
            receptorText.Name = "receptorText";
            receptorText.ReadOnly = true;
            toolTip1.SetToolTip(receptorText, resources.GetString("receptorText.ToolTip"));
            // 
            // searchButton
            // 
            resources.ApplyResources(searchButton, "searchButton");
            emptyErrorProvider.SetError(searchButton, resources.GetString("searchButton.Error"));
            emptyErrorProvider.SetIconAlignment(searchButton, (ErrorIconAlignment)resources.GetObject("searchButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(searchButton, (int)resources.GetObject("searchButton.IconPadding"));
            searchButton.Name = "searchButton";
            toolTip1.SetToolTip(searchButton, resources.GetString("searchButton.ToolTip"));
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // listButton
            // 
            resources.ApplyResources(listButton, "listButton");
            emptyErrorProvider.SetError(listButton, resources.GetString("listButton.Error"));
            emptyErrorProvider.SetIconAlignment(listButton, (ErrorIconAlignment)resources.GetObject("listButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(listButton, (int)resources.GetObject("listButton.IconPadding"));
            listButton.Name = "listButton";
            toolTip1.SetToolTip(listButton, resources.GetString("listButton.ToolTip"));
            listButton.UseVisualStyleBackColor = true;
            listButton.Click += listButton_Click;
            // 
            // apkText
            // 
            resources.ApplyResources(apkText, "apkText");
            emptyErrorProvider.SetError(apkText, resources.GetString("apkText.Error"));
            emptyErrorProvider.SetIconAlignment(apkText, (ErrorIconAlignment)resources.GetObject("apkText.IconAlignment"));
            emptyErrorProvider.SetIconPadding(apkText, (int)resources.GetObject("apkText.IconPadding"));
            apkText.Name = "apkText";
            toolTip1.SetToolTip(apkText, resources.GetString("apkText.ToolTip"));
            // 
            // ipLabel
            // 
            resources.ApplyResources(ipLabel, "ipLabel");
            emptyErrorProvider.SetError(ipLabel, resources.GetString("ipLabel.Error"));
            emptyErrorProvider.SetIconAlignment(ipLabel, (ErrorIconAlignment)resources.GetObject("ipLabel.IconAlignment"));
            emptyErrorProvider.SetIconPadding(ipLabel, (int)resources.GetObject("ipLabel.IconPadding"));
            ipLabel.Name = "ipLabel";
            toolTip1.SetToolTip(ipLabel, resources.GetString("ipLabel.ToolTip"));
            // 
            // packageText
            // 
            resources.ApplyResources(packageText, "packageText");
            packageText.BackColor = SystemColors.Window;
            packageText.BorderStyle = BorderStyle.None;
            emptyErrorProvider.SetError(packageText, resources.GetString("packageText.Error"));
            emptyErrorProvider.SetIconAlignment(packageText, (ErrorIconAlignment)resources.GetObject("packageText.IconAlignment"));
            emptyErrorProvider.SetIconPadding(packageText, (int)resources.GetObject("packageText.IconPadding"));
            packageText.Name = "packageText";
            packageText.ReadOnly = true;
            toolTip1.SetToolTip(packageText, resources.GetString("packageText.ToolTip"));
            // 
            // apkOpenFileDialog
            // 
            apkOpenFileDialog.DefaultExt = "apk";
            resources.ApplyResources(apkOpenFileDialog, "apkOpenFileDialog");
            apkOpenFileDialog.FilterIndex = 2;
            // 
            // installButton
            // 
            resources.ApplyResources(installButton, "installButton");
            installButton.BackColor = SystemColors.Window;
            emptyErrorProvider.SetError(installButton, resources.GetString("installButton.Error"));
            installButton.ForeColor = Color.SeaGreen;
            emptyErrorProvider.SetIconAlignment(installButton, (ErrorIconAlignment)resources.GetObject("installButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(installButton, (int)resources.GetObject("installButton.IconPadding"));
            installButton.Name = "installButton";
            toolTip1.SetToolTip(installButton, resources.GetString("installButton.ToolTip"));
            installButton.UseVisualStyleBackColor = false;
            installButton.Click += InstallButton_Click;
            // 
            // cancelButton
            // 
            resources.ApplyResources(cancelButton, "cancelButton");
            emptyErrorProvider.SetError(cancelButton, resources.GetString("cancelButton.Error"));
            emptyErrorProvider.SetIconAlignment(cancelButton, (ErrorIconAlignment)resources.GetObject("cancelButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(cancelButton, (int)resources.GetObject("cancelButton.IconPadding"));
            cancelButton.Name = "cancelButton";
            toolTip1.SetToolTip(cancelButton, resources.GetString("cancelButton.ToolTip"));
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // emptyErrorProvider
            // 
            emptyErrorProvider.ContainerControl = this;
            resources.ApplyResources(emptyErrorProvider, "emptyErrorProvider");
            // 
            // deviceOwnerButton
            // 
            resources.ApplyResources(deviceOwnerButton, "deviceOwnerButton");
            deviceOwnerButton.BackColor = SystemColors.Window;
            emptyErrorProvider.SetError(deviceOwnerButton, resources.GetString("deviceOwnerButton.Error"));
            deviceOwnerButton.ForeColor = Color.OrangeRed;
            emptyErrorProvider.SetIconAlignment(deviceOwnerButton, (ErrorIconAlignment)resources.GetObject("deviceOwnerButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(deviceOwnerButton, (int)resources.GetObject("deviceOwnerButton.IconPadding"));
            deviceOwnerButton.Name = "deviceOwnerButton";
            toolTip1.SetToolTip(deviceOwnerButton, resources.GetString("deviceOwnerButton.ToolTip"));
            deviceOwnerButton.UseVisualStyleBackColor = false;
            deviceOwnerButton.Click += DeviceOwnerButton_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(connectCheck);
            panel1.Controls.Add(deviceOwnerCheck);
            panel1.Controls.Add(installCheck);
            panel1.Controls.Add(searchCheck);
            panel1.Controls.Add(listCheck);
            panel1.Controls.Add(label4);
            emptyErrorProvider.SetError(panel1, resources.GetString("panel1.Error"));
            emptyErrorProvider.SetIconAlignment(panel1, (ErrorIconAlignment)resources.GetObject("panel1.IconAlignment"));
            emptyErrorProvider.SetIconPadding(panel1, (int)resources.GetObject("panel1.IconPadding"));
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // connectCheck
            // 
            resources.ApplyResources(connectCheck, "connectCheck");
            connectCheck.AutoCheck = false;
            emptyErrorProvider.SetError(connectCheck, resources.GetString("connectCheck.Error"));
            emptyErrorProvider.SetIconAlignment(connectCheck, (ErrorIconAlignment)resources.GetObject("connectCheck.IconAlignment"));
            emptyErrorProvider.SetIconPadding(connectCheck, (int)resources.GetObject("connectCheck.IconPadding"));
            connectCheck.Name = "connectCheck";
            toolTip1.SetToolTip(connectCheck, resources.GetString("connectCheck.ToolTip"));
            connectCheck.UseVisualStyleBackColor = true;
            // 
            // deviceOwnerCheck
            // 
            resources.ApplyResources(deviceOwnerCheck, "deviceOwnerCheck");
            deviceOwnerCheck.AutoCheck = false;
            emptyErrorProvider.SetError(deviceOwnerCheck, resources.GetString("deviceOwnerCheck.Error"));
            emptyErrorProvider.SetIconAlignment(deviceOwnerCheck, (ErrorIconAlignment)resources.GetObject("deviceOwnerCheck.IconAlignment"));
            emptyErrorProvider.SetIconPadding(deviceOwnerCheck, (int)resources.GetObject("deviceOwnerCheck.IconPadding"));
            deviceOwnerCheck.Name = "deviceOwnerCheck";
            toolTip1.SetToolTip(deviceOwnerCheck, resources.GetString("deviceOwnerCheck.ToolTip"));
            deviceOwnerCheck.UseVisualStyleBackColor = true;
            // 
            // installCheck
            // 
            resources.ApplyResources(installCheck, "installCheck");
            installCheck.AutoCheck = false;
            emptyErrorProvider.SetError(installCheck, resources.GetString("installCheck.Error"));
            emptyErrorProvider.SetIconAlignment(installCheck, (ErrorIconAlignment)resources.GetObject("installCheck.IconAlignment"));
            emptyErrorProvider.SetIconPadding(installCheck, (int)resources.GetObject("installCheck.IconPadding"));
            installCheck.Name = "installCheck";
            toolTip1.SetToolTip(installCheck, resources.GetString("installCheck.ToolTip"));
            installCheck.UseVisualStyleBackColor = true;
            // 
            // searchCheck
            // 
            resources.ApplyResources(searchCheck, "searchCheck");
            searchCheck.AutoCheck = false;
            emptyErrorProvider.SetError(searchCheck, resources.GetString("searchCheck.Error"));
            emptyErrorProvider.SetIconAlignment(searchCheck, (ErrorIconAlignment)resources.GetObject("searchCheck.IconAlignment"));
            emptyErrorProvider.SetIconPadding(searchCheck, (int)resources.GetObject("searchCheck.IconPadding"));
            searchCheck.Name = "searchCheck";
            toolTip1.SetToolTip(searchCheck, resources.GetString("searchCheck.ToolTip"));
            searchCheck.UseVisualStyleBackColor = true;
            // 
            // listCheck
            // 
            resources.ApplyResources(listCheck, "listCheck");
            listCheck.AutoCheck = false;
            emptyErrorProvider.SetError(listCheck, resources.GetString("listCheck.Error"));
            emptyErrorProvider.SetIconAlignment(listCheck, (ErrorIconAlignment)resources.GetObject("listCheck.IconAlignment"));
            emptyErrorProvider.SetIconPadding(listCheck, (int)resources.GetObject("listCheck.IconPadding"));
            listCheck.Name = "listCheck";
            toolTip1.SetToolTip(listCheck, resources.GetString("listCheck.ToolTip"));
            listCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            emptyErrorProvider.SetError(label4, resources.GetString("label4.Error"));
            emptyErrorProvider.SetIconAlignment(label4, (ErrorIconAlignment)resources.GetObject("label4.IconAlignment"));
            emptyErrorProvider.SetIconPadding(label4, (int)resources.GetObject("label4.IconPadding"));
            label4.Name = "label4";
            toolTip1.SetToolTip(label4, resources.GetString("label4.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            emptyErrorProvider.SetError(pictureBox1, resources.GetString("pictureBox1.Error"));
            emptyErrorProvider.SetIconAlignment(pictureBox1, (ErrorIconAlignment)resources.GetObject("pictureBox1.IconAlignment"));
            emptyErrorProvider.SetIconPadding(pictureBox1, (int)resources.GetObject("pictureBox1.IconPadding"));
            pictureBox1.Image = Properties.Resources.creditv_logo;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(logText);
            emptyErrorProvider.SetError(groupBox2, resources.GetString("groupBox2.Error"));
            emptyErrorProvider.SetIconAlignment(groupBox2, (ErrorIconAlignment)resources.GetObject("groupBox2.IconAlignment"));
            emptyErrorProvider.SetIconPadding(groupBox2, (int)resources.GetObject("groupBox2.IconPadding"));
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            toolTip1.SetToolTip(groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // logText
            // 
            resources.ApplyResources(logText, "logText");
            logText.BackColor = SystemColors.ControlLightLight;
            logText.BorderStyle = BorderStyle.None;
            emptyErrorProvider.SetError(logText, resources.GetString("logText.Error"));
            emptyErrorProvider.SetIconAlignment(logText, (ErrorIconAlignment)resources.GetObject("logText.IconAlignment"));
            emptyErrorProvider.SetIconPadding(logText, (int)resources.GetObject("logText.IconPadding"));
            logText.Name = "logText";
            logText.ReadOnly = true;
            toolTip1.SetToolTip(logText, resources.GetString("logText.ToolTip"));
            // 
            // newButton
            // 
            resources.ApplyResources(newButton, "newButton");
            emptyErrorProvider.SetError(newButton, resources.GetString("newButton.Error"));
            emptyErrorProvider.SetIconAlignment(newButton, (ErrorIconAlignment)resources.GetObject("newButton.IconAlignment"));
            emptyErrorProvider.SetIconPadding(newButton, (int)resources.GetObject("newButton.IconPadding"));
            newButton.Name = "newButton";
            toolTip1.SetToolTip(newButton, resources.GetString("newButton.ToolTip"));
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += NewButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Nota importante";
            // 
            // SetupForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            CancelButton = cancelButton;
            Controls.Add(newButton);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(packageText);
            Controls.Add(panel1);
            Controls.Add(deviceOwnerButton);
            Controls.Add(cancelButton);
            Controls.Add(installButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SetupForm";
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Load += SetupForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emptyErrorProvider).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label ipLabel;
        private Button searchButton;
        private Button listButton;
        private TextBox apkText;
        private OpenFileDialog apkOpenFileDialog;
        private Button installButton;
        private Button cancelButton;
        private LinkLabel apkLink;
        private TextBox receptorText;
        private TextBox packageText;
        private ErrorProvider emptyErrorProvider;
        private FileSystemWatcher fileSystemWatcher1;
        private Button deviceOwnerButton;
        private MaskedTextBox ipText;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox deviceOwnerCheck;
        private CheckBox installCheck;
        private CheckBox searchCheck;
        private CheckBox listCheck;
        private CheckBox connectCheck;
        private Button connectButton;
        private TextBox devicesText;
        private GroupBox groupBox2;
        private TextBox logText;
        private Label label5;
        private ToolTip toolTip1;
        private Button newButton;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}