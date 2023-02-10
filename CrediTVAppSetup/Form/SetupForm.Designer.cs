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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.devicesText = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.ipText = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receptorText = new System.Windows.Forms.TextBox();
            this.packageText = new System.Windows.Forms.TextBox();
            this.apkLink = new System.Windows.Forms.LinkLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.apkText = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.apkOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.installButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.emptyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.deviceOwnerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectCheck = new System.Windows.Forms.CheckBox();
            this.deviceOwnerCheck = new System.Windows.Forms.CheckBox();
            this.installCheck = new System.Windows.Forms.CheckBox();
            this.searchCheck = new System.Windows.Forms.CheckBox();
            this.listCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.devicesText);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.ipText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.receptorText);
            this.groupBox1.Controls.Add(this.packageText);
            this.groupBox1.Controls.Add(this.apkLink);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.listButton);
            this.groupBox1.Controls.Add(this.apkText);
            this.groupBox1.Controls.Add(this.ipLabel);
            this.groupBox1.Location = new System.Drawing.Point(247, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dispositivos:";
            // 
            // devicesText
            // 
            this.devicesText.BackColor = System.Drawing.SystemColors.Window;
            this.devicesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.devicesText.Location = new System.Drawing.Point(133, 44);
            this.devicesText.Multiline = true;
            this.devicesText.Name = "devicesText";
            this.devicesText.ReadOnly = true;
            this.devicesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.devicesText.Size = new System.Drawing.Size(374, 137);
            this.devicesText.TabIndex = 16;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(267, 187);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(94, 29);
            this.connectButton.TabIndex = 15;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(133, 189);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(129, 27);
            this.ipText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Receptor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Paquete:";
            // 
            // receptorText
            // 
            this.receptorText.BackColor = System.Drawing.SystemColors.Window;
            this.receptorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receptorText.Location = new System.Drawing.Point(133, 307);
            this.receptorText.Name = "receptorText";
            this.receptorText.ReadOnly = true;
            this.receptorText.Size = new System.Drawing.Size(230, 20);
            this.receptorText.TabIndex = 11;
            // 
            // packageText
            // 
            this.packageText.BackColor = System.Drawing.SystemColors.Window;
            this.packageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.packageText.Location = new System.Drawing.Point(133, 271);
            this.packageText.Name = "packageText";
            this.packageText.ReadOnly = true;
            this.packageText.Size = new System.Drawing.Size(230, 20);
            this.packageText.TabIndex = 10;
            // 
            // apkLink
            // 
            this.apkLink.AutoSize = true;
            this.apkLink.Location = new System.Drawing.Point(17, 231);
            this.apkLink.Name = "apkLink";
            this.apkLink.Size = new System.Drawing.Size(113, 20);
            this.apkLink.TabIndex = 9;
            this.apkLink.TabStop = true;
            this.apkLink.Text = "APK Aplicación:";
            this.apkLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.apkLink_LinkClicked);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(512, 227);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(512, 44);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(94, 29);
            this.listButton.TabIndex = 6;
            this.listButton.Text = "Listar";
            this.toolTip1.SetToolTip(this.listButton, "Apague los dispositivos que no forman parte del proceso.");
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // apkText
            // 
            this.apkText.Location = new System.Drawing.Point(133, 228);
            this.apkText.Name = "apkText";
            this.apkText.Size = new System.Drawing.Size(373, 27);
            this.apkText.TabIndex = 5;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(27, 192);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(102, 20);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP Dispositivo:";
            // 
            // apkOpenFileDialog
            // 
            this.apkOpenFileDialog.DefaultExt = "apk";
            this.apkOpenFileDialog.Filter = "apk files (*.apk)|*.apk";
            this.apkOpenFileDialog.FilterIndex = 2;
            this.apkOpenFileDialog.Title = "Buscar Archivo APK";
            // 
            // installButton
            // 
            this.installButton.BackColor = System.Drawing.SystemColors.Window;
            this.installButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.installButton.Location = new System.Drawing.Point(322, 515);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(165, 29);
            this.installButton.TabIndex = 8;
            this.installButton.Text = "Instalar Aplicación";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(777, 515);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // emptyErrorProvider
            // 
            this.emptyErrorProvider.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // deviceOwnerButton
            // 
            this.deviceOwnerButton.BackColor = System.Drawing.SystemColors.Window;
            this.deviceOwnerButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.deviceOwnerButton.Location = new System.Drawing.Point(491, 515);
            this.deviceOwnerButton.Name = "deviceOwnerButton";
            this.deviceOwnerButton.Size = new System.Drawing.Size(279, 29);
            this.deviceOwnerButton.TabIndex = 10;
            this.deviceOwnerButton.Text = "Establecer Propietario de Dispositivo";
            this.deviceOwnerButton.UseVisualStyleBackColor = false;
            this.deviceOwnerButton.Click += new System.EventHandler(this.DeviceOwnerButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.connectCheck);
            this.panel1.Controls.Add(this.deviceOwnerCheck);
            this.panel1.Controls.Add(this.installCheck);
            this.panel1.Controls.Add(this.searchCheck);
            this.panel1.Controls.Add(this.listCheck);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 353);
            this.panel1.TabIndex = 11;
            // 
            // connectCheck
            // 
            this.connectCheck.AutoCheck = false;
            this.connectCheck.AutoSize = true;
            this.connectCheck.Location = new System.Drawing.Point(27, 113);
            this.connectCheck.Name = "connectCheck";
            this.connectCheck.Size = new System.Drawing.Size(168, 24);
            this.connectCheck.TabIndex = 17;
            this.connectCheck.Text = "Conectar Dispositivo";
            this.connectCheck.UseVisualStyleBackColor = true;
            // 
            // deviceOwnerCheck
            // 
            this.deviceOwnerCheck.AutoCheck = false;
            this.deviceOwnerCheck.AutoSize = true;
            this.deviceOwnerCheck.Location = new System.Drawing.Point(27, 289);
            this.deviceOwnerCheck.Name = "deviceOwnerCheck";
            this.deviceOwnerCheck.Size = new System.Drawing.Size(177, 24);
            this.deviceOwnerCheck.TabIndex = 16;
            this.deviceOwnerCheck.Text = "Establecer Propietario";
            this.deviceOwnerCheck.UseVisualStyleBackColor = true;
            // 
            // installCheck
            // 
            this.installCheck.AutoCheck = false;
            this.installCheck.AutoSize = true;
            this.installCheck.Location = new System.Drawing.Point(27, 229);
            this.installCheck.Name = "installCheck";
            this.installCheck.Size = new System.Drawing.Size(153, 24);
            this.installCheck.TabIndex = 15;
            this.installCheck.Text = "Instalar Aplicación";
            this.installCheck.UseVisualStyleBackColor = true;
            // 
            // searchCheck
            // 
            this.searchCheck.AutoCheck = false;
            this.searchCheck.AutoSize = true;
            this.searchCheck.Location = new System.Drawing.Point(27, 171);
            this.searchCheck.Name = "searchCheck";
            this.searchCheck.Size = new System.Drawing.Size(148, 24);
            this.searchCheck.TabIndex = 14;
            this.searchCheck.Text = "Buscar Aplicación";
            this.searchCheck.UseVisualStyleBackColor = true;
            // 
            // listCheck
            // 
            this.listCheck.AutoCheck = false;
            this.listCheck.AutoSize = true;
            this.listCheck.Location = new System.Drawing.Point(27, 57);
            this.listCheck.Name = "listCheck";
            this.listCheck.Size = new System.Drawing.Size(150, 24);
            this.listCheck.TabIndex = 13;
            this.listCheck.Text = "Listar Dispositivos";
            this.listCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Proceso de instalación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CrediTVInstaller.Properties.Resources.creditv_logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logText);
            this.groupBox2.Location = new System.Drawing.Point(247, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 119);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro ADB";
            // 
            // logText
            // 
            this.logText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logText.Location = new System.Drawing.Point(7, 23);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(607, 91);
            this.logText.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Nota importante";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(11, 515);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(94, 29);
            this.newButton.TabIndex = 14;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deviceOwnerButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.Text = "CreditTV Installer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private Label label3;
        private Label label2;
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
    }
}