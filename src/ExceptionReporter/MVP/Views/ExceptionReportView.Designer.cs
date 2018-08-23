namespace ExceptionReporting.MVP.Views
{
	public partial class ExceptionReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionReportView));
			this.listviewAssemblies = new System.Windows.Forms.ListView();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.picGeneral = new System.Windows.Forms.PictureBox();
			this.txtExceptionMessage = new System.Windows.Forms.TextBox();
			this.lblExplanation = new System.Windows.Forms.Label();
			this.txtUserExplanation = new System.Windows.Forms.TextBox();
			this.lblRegion = new System.Windows.Forms.Label();
			this.txtRegion = new System.Windows.Forms.TextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.lblTime = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.lblApplication = new System.Windows.Forms.Label();
			this.txtApplicationName = new System.Windows.Forms.TextBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.txtVersion = new System.Windows.Forms.TextBox();
			this.tabExceptions = new System.Windows.Forms.TabPage();
			this.tabAssemblies = new System.Windows.Forms.TabPage();
			this.tabSysInfo = new System.Windows.Forms.TabPage();
			this.treeEnvironment = new System.Windows.Forms.TreeView();
			this.btnSave = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.btnEmail = new System.Windows.Forms.Button();
			this.lblProgressMessage = new System.Windows.Forms.Label();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnDetailToggle = new System.Windows.Forms.Button();
			this.txtExceptionMessageLarge = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.lessDetailPanel = new System.Windows.Forms.Panel();
			this.lessDetail_optionsPanel = new System.Windows.Forms.Panel();
			this.lblContactCompany = new System.Windows.Forms.Label();
			this.btnSimpleEmail = new System.Windows.Forms.Button();
			this.btnSimpleDetailToggle = new System.Windows.Forms.Button();
			this.btnSimpleCopy = new System.Windows.Forms.Button();
			this.txtExceptionMessageLarge2 = new System.Windows.Forms.TextBox();
			this.lessDetail_alertIcon = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picGeneral)).BeginInit();
			this.tabAssemblies.SuspendLayout();
			this.tabSysInfo.SuspendLayout();
			this.lessDetailPanel.SuspendLayout();
			this.lessDetail_optionsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lessDetail_alertIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// listviewAssemblies
			// 
			this.listviewAssemblies.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listviewAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listviewAssemblies.FullRowSelect = true;
			this.listviewAssemblies.HotTracking = true;
			this.listviewAssemblies.HoverSelection = true;
			this.listviewAssemblies.Location = new System.Drawing.Point(0, 0);
			this.listviewAssemblies.Name = "listviewAssemblies";
			this.listviewAssemblies.Size = new System.Drawing.Size(531, 345);
			this.listviewAssemblies.TabIndex = 21;
			this.listviewAssemblies.UseCompatibleStateImageBehavior = false;
			this.listviewAssemblies.View = System.Windows.Forms.View.Details;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabGeneral);
			this.tabControl.Controls.Add(this.tabExceptions);
			this.tabControl.Controls.Add(this.tabAssemblies);
			this.tabControl.Controls.Add(this.tabSysInfo);
			this.tabControl.HotTrack = true;
			this.tabControl.Location = new System.Drawing.Point(6, 6);
			this.tabControl.MinimumSize = new System.Drawing.Size(200, 0);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.ShowToolTips = true;
			this.tabControl.Size = new System.Drawing.Size(539, 371);
			this.tabControl.TabIndex = 6;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.picGeneral);
			this.tabGeneral.Controls.Add(this.txtExceptionMessage);
			this.tabGeneral.Controls.Add(this.lblExplanation);
			this.tabGeneral.Controls.Add(this.txtUserExplanation);
			this.tabGeneral.Controls.Add(this.lblRegion);
			this.tabGeneral.Controls.Add(this.txtRegion);
			this.tabGeneral.Controls.Add(this.lblDate);
			this.tabGeneral.Controls.Add(this.txtDate);
			this.tabGeneral.Controls.Add(this.lblTime);
			this.tabGeneral.Controls.Add(this.txtTime);
			this.tabGeneral.Controls.Add(this.lblApplication);
			this.tabGeneral.Controls.Add(this.txtApplicationName);
			this.tabGeneral.Controls.Add(this.lblVersion);
			this.tabGeneral.Controls.Add(this.txtVersion);
			this.tabGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(531, 345);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// picGeneral
			// 
			this.picGeneral.Image = ((System.Drawing.Image)(resources.GetObject("picGeneral.Image")));
			this.picGeneral.Location = new System.Drawing.Point(8, 7);
			this.picGeneral.Name = "picGeneral";
			this.picGeneral.Size = new System.Drawing.Size(64, 64);
			this.picGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picGeneral.TabIndex = 25;
			this.picGeneral.TabStop = false;
			// 
			// txtExceptionMessage
			// 
			this.txtExceptionMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExceptionMessage.BackColor = System.Drawing.Color.White;
			this.txtExceptionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExceptionMessage.Location = new System.Drawing.Point(78, 7);
			this.txtExceptionMessage.Multiline = true;
			this.txtExceptionMessage.Name = "txtExceptionMessage";
			this.txtExceptionMessage.ReadOnly = true;
			this.txtExceptionMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtExceptionMessage.Size = new System.Drawing.Size(438, 68);
			this.txtExceptionMessage.TabIndex = 0;
			this.txtExceptionMessage.Text = "No message";
			// 
			// lblExplanation
			// 
			this.lblExplanation.AutoSize = true;
			this.lblExplanation.Location = new System.Drawing.Point(6, 191);
			this.lblExplanation.Name = "lblExplanation";
			this.lblExplanation.Size = new System.Drawing.Size(334, 13);
			this.lblExplanation.TabIndex = 14;
			this.lblExplanation.Text = "Please enter a brief explanation of events leading up to this exception";
			// 
			// txtUserExplanation
			// 
			this.txtUserExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserExplanation.BackColor = System.Drawing.Color.Cornsilk;
			this.txtUserExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserExplanation.Location = new System.Drawing.Point(8, 210);
			this.txtUserExplanation.Multiline = true;
			this.txtUserExplanation.Name = "txtUserExplanation";
			this.txtUserExplanation.Size = new System.Drawing.Size(508, 132);
			this.txtUserExplanation.TabIndex = 6;
			// 
			// lblRegion
			// 
			this.lblRegion.AutoSize = true;
			this.lblRegion.Location = new System.Drawing.Point(254, 127);
			this.lblRegion.Name = "lblRegion";
			this.lblRegion.Size = new System.Drawing.Size(41, 13);
			this.lblRegion.TabIndex = 7;
			this.lblRegion.Text = "Region";
			// 
			// txtRegion
			// 
			this.txtRegion.BackColor = System.Drawing.Color.Snow;
			this.txtRegion.Location = new System.Drawing.Point(310, 124);
			this.txtRegion.Name = "txtRegion";
			this.txtRegion.ReadOnly = true;
			this.txtRegion.Size = new System.Drawing.Size(141, 20);
			this.txtRegion.TabIndex = 3;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(14, 159);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(30, 13);
			this.lblDate.TabIndex = 9;
			this.lblDate.Text = "Date";
			// 
			// txtDate
			// 
			this.txtDate.BackColor = System.Drawing.Color.Snow;
			this.txtDate.Location = new System.Drawing.Point(78, 156);
			this.txtDate.Name = "txtDate";
			this.txtDate.ReadOnly = true;
			this.txtDate.Size = new System.Drawing.Size(152, 20);
			this.txtDate.TabIndex = 4;
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(254, 159);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(30, 13);
			this.lblTime.TabIndex = 11;
			this.lblTime.Text = "Time";
			// 
			// txtTime
			// 
			this.txtTime.BackColor = System.Drawing.Color.Snow;
			this.txtTime.Location = new System.Drawing.Point(310, 156);
			this.txtTime.Name = "txtTime";
			this.txtTime.ReadOnly = true;
			this.txtTime.Size = new System.Drawing.Size(141, 20);
			this.txtTime.TabIndex = 5;
			// 
			// lblApplication
			// 
			this.lblApplication.AutoSize = true;
			this.lblApplication.Location = new System.Drawing.Point(14, 94);
			this.lblApplication.Name = "lblApplication";
			this.lblApplication.Size = new System.Drawing.Size(59, 13);
			this.lblApplication.TabIndex = 3;
			this.lblApplication.Text = "Application";
			// 
			// txtApplicationName
			// 
			this.txtApplicationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtApplicationName.BackColor = System.Drawing.Color.Snow;
			this.txtApplicationName.Location = new System.Drawing.Point(78, 92);
			this.txtApplicationName.Name = "txtApplicationName";
			this.txtApplicationName.ReadOnly = true;
			this.txtApplicationName.Size = new System.Drawing.Size(438, 20);
			this.txtApplicationName.TabIndex = 1;
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(14, 127);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(48, 16);
			this.lblVersion.TabIndex = 5;
			this.lblVersion.Text = "Version";
			// 
			// txtVersion
			// 
			this.txtVersion.BackColor = System.Drawing.Color.Snow;
			this.txtVersion.Location = new System.Drawing.Point(78, 124);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.ReadOnly = true;
			this.txtVersion.Size = new System.Drawing.Size(152, 20);
			this.txtVersion.TabIndex = 2;
			// 
			// tabExceptions
			// 
			this.tabExceptions.Location = new System.Drawing.Point(4, 22);
			this.tabExceptions.Name = "tabExceptions";
			this.tabExceptions.Size = new System.Drawing.Size(531, 345);
			this.tabExceptions.TabIndex = 1;
			this.tabExceptions.Text = "Exceptions";
			this.tabExceptions.UseVisualStyleBackColor = true;
			// 
			// tabAssemblies
			// 
			this.tabAssemblies.Controls.Add(this.listviewAssemblies);
			this.tabAssemblies.Location = new System.Drawing.Point(4, 22);
			this.tabAssemblies.Name = "tabAssemblies";
			this.tabAssemblies.Size = new System.Drawing.Size(531, 345);
			this.tabAssemblies.TabIndex = 6;
			this.tabAssemblies.Text = "Assemblies";
			this.tabAssemblies.UseVisualStyleBackColor = true;
			// 
			// tabSysInfo
			// 
			this.tabSysInfo.Controls.Add(this.treeEnvironment);
			this.tabSysInfo.Location = new System.Drawing.Point(4, 22);
			this.tabSysInfo.Name = "tabSysInfo";
			this.tabSysInfo.Size = new System.Drawing.Size(531, 345);
			this.tabSysInfo.TabIndex = 3;
			this.tabSysInfo.Text = "System";
			this.tabSysInfo.UseVisualStyleBackColor = true;
			// 
			// treeEnvironment
			// 
			this.treeEnvironment.BackColor = System.Drawing.SystemColors.Window;
			this.treeEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeEnvironment.HotTracking = true;
			this.treeEnvironment.Location = new System.Drawing.Point(0, 0);
			this.treeEnvironment.Name = "treeEnvironment";
			this.treeEnvironment.Size = new System.Drawing.Size(531, 345);
			this.treeEnvironment.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(318, 380);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(72, 32);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.progressBar.Location = new System.Drawing.Point(5, 396);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(141, 16);
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progressBar.TabIndex = 53;
			// 
			// btnEmail
			// 
			this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
			this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmail.Location = new System.Drawing.Point(395, 380);
			this.btnEmail.Name = "btnEmail";
			this.btnEmail.Size = new System.Drawing.Size(72, 32);
			this.btnEmail.TabIndex = 1;
			this.btnEmail.Text = "Email";
			this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblProgressMessage
			// 
			this.lblProgressMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblProgressMessage.AutoSize = true;
			this.lblProgressMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblProgressMessage.Location = new System.Drawing.Point(3, 380);
			this.lblProgressMessage.Name = "lblProgressMessage";
			this.lblProgressMessage.Size = new System.Drawing.Size(150, 13);
			this.lblProgressMessage.TabIndex = 52;
			this.lblProgressMessage.Text = "Loading system information...";
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
			this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCopy.Location = new System.Drawing.Point(241, 380);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(72, 32);
			this.btnCopy.TabIndex = 3;
			this.btnCopy.Text = "Copy";
			this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnDetailToggle
			// 
			this.btnDetailToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDetailToggle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetailToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDetailToggle.Location = new System.Drawing.Point(164, 380);
			this.btnDetailToggle.Name = "btnDetailToggle";
			this.btnDetailToggle.Size = new System.Drawing.Size(72, 32);
			this.btnDetailToggle.TabIndex = 4;
			this.btnDetailToggle.Text = "Less Detail";
			// 
			// txtExceptionMessageLarge
			// 
			this.txtExceptionMessageLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExceptionMessageLarge.BackColor = System.Drawing.Color.White;
			this.txtExceptionMessageLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExceptionMessageLarge.Location = new System.Drawing.Point(6, 6);
			this.txtExceptionMessageLarge.Multiline = true;
			this.txtExceptionMessageLarge.Name = "txtExceptionMessageLarge";
			this.txtExceptionMessageLarge.ReadOnly = true;
			this.txtExceptionMessageLarge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtExceptionMessageLarge.Size = new System.Drawing.Size(538, 368);
			this.txtExceptionMessageLarge.TabIndex = 5;
			this.txtExceptionMessageLarge.Text = "No message";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(472, 380);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(72, 32);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			// 
			// lessDetailPanel
			// 
			this.lessDetailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.lessDetailPanel.BackColor = System.Drawing.Color.White;
			this.lessDetailPanel.Controls.Add(this.lessDetail_optionsPanel);
			this.lessDetailPanel.Controls.Add(this.txtExceptionMessageLarge2);
			this.lessDetailPanel.Controls.Add(this.lessDetail_alertIcon);
			this.lessDetailPanel.Controls.Add(this.label1);
			this.lessDetailPanel.Location = new System.Drawing.Point(0, 0);
			this.lessDetailPanel.Name = "lessDetailPanel";
			this.lessDetailPanel.Size = new System.Drawing.Size(400, 200);
			this.lessDetailPanel.TabIndex = 54;
			// 
			// lessDetail_optionsPanel
			// 
			this.lessDetail_optionsPanel.AutoSize = true;
			this.lessDetail_optionsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.lessDetail_optionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
			this.lessDetail_optionsPanel.Controls.Add(this.lblContactCompany);
			this.lessDetail_optionsPanel.Controls.Add(this.btnSimpleEmail);
			this.lessDetail_optionsPanel.Controls.Add(this.btnSimpleDetailToggle);
			this.lessDetail_optionsPanel.Controls.Add(this.btnSimpleCopy);
			this.lessDetail_optionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lessDetail_optionsPanel.Location = new System.Drawing.Point(0, 121);
			this.lessDetail_optionsPanel.Name = "lessDetail_optionsPanel";
			this.lessDetail_optionsPanel.Padding = new System.Windows.Forms.Padding(8);
			this.lessDetail_optionsPanel.Size = new System.Drawing.Size(400, 79);
			this.lessDetail_optionsPanel.TabIndex = 26;
			// 
			// lblContactCompany
			// 
			this.lblContactCompany.AutoSize = true;
			this.lblContactCompany.ForeColor = System.Drawing.Color.SlateGray;
			this.lblContactCompany.Location = new System.Drawing.Point(13, 11);
			this.lblContactCompany.Name = "lblContactCompany";
			this.lblContactCompany.Size = new System.Drawing.Size(0, 13);
			this.lblContactCompany.TabIndex = 3;
			// 
			// btnSimpleEmail
			// 
			this.btnSimpleEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSimpleEmail.FlatAppearance.BorderSize = 0;
			this.btnSimpleEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
			this.btnSimpleEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
			this.btnSimpleEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimpleEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSimpleEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpleEmail.Image")));
			this.btnSimpleEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSimpleEmail.Location = new System.Drawing.Point(271, 36);
			this.btnSimpleEmail.Name = "btnSimpleEmail";
			this.btnSimpleEmail.Size = new System.Drawing.Size(118, 32);
			this.btnSimpleEmail.TabIndex = 1;
			this.btnSimpleEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSimpleDetailToggle
			// 
			this.btnSimpleDetailToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSimpleDetailToggle.FlatAppearance.BorderSize = 0;
			this.btnSimpleDetailToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
			this.btnSimpleDetailToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
			this.btnSimpleDetailToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimpleDetailToggle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSimpleDetailToggle.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpleDetailToggle.Image")));
			this.btnSimpleDetailToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSimpleDetailToggle.Location = new System.Drawing.Point(12, 36);
			this.btnSimpleDetailToggle.Name = "btnSimpleDetailToggle";
			this.btnSimpleDetailToggle.Size = new System.Drawing.Size(96, 32);
			this.btnSimpleDetailToggle.TabIndex = 4;
			this.btnSimpleDetailToggle.Text = "More detail";
			this.btnSimpleDetailToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSimpleCopy
			// 
			this.btnSimpleCopy.FlatAppearance.BorderSize = 0;
			this.btnSimpleCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
			this.btnSimpleCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
			this.btnSimpleCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimpleCopy.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSimpleCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpleCopy.Image")));
			this.btnSimpleCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSimpleCopy.Location = new System.Drawing.Point(144, 36);
			this.btnSimpleCopy.Name = "btnSimpleCopy";
			this.btnSimpleCopy.Size = new System.Drawing.Size(109, 32);
			this.btnSimpleCopy.TabIndex = 3;
			this.btnSimpleCopy.Text = "Copy details";
			this.btnSimpleCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtExceptionMessageLarge2
			// 
			this.txtExceptionMessageLarge2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExceptionMessageLarge2.BackColor = System.Drawing.Color.White;
			this.txtExceptionMessageLarge2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtExceptionMessageLarge2.Location = new System.Drawing.Point(86, 62);
			this.txtExceptionMessageLarge2.Multiline = true;
			this.txtExceptionMessageLarge2.Name = "txtExceptionMessageLarge2";
			this.txtExceptionMessageLarge2.ReadOnly = true;
			this.txtExceptionMessageLarge2.Size = new System.Drawing.Size(299, 53);
			this.txtExceptionMessageLarge2.TabIndex = 0;
			this.txtExceptionMessageLarge2.Text = "No message";
			// 
			// lessDetail_alertIcon
			// 
			this.lessDetail_alertIcon.Image = ((System.Drawing.Image)(resources.GetObject("lessDetail_alertIcon.Image")));
			this.lessDetail_alertIcon.Location = new System.Drawing.Point(14, 13);
			this.lessDetail_alertIcon.Name = "lessDetail_alertIcon";
			this.lessDetail_alertIcon.Size = new System.Drawing.Size(64, 64);
			this.lessDetail_alertIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.lessDetail_alertIcon.TabIndex = 25;
			this.lessDetail_alertIcon.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(84, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "Operation Failed";
			// 
			// ExceptionReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(551, 416);
			this.Controls.Add(this.lessDetailPanel);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnDetailToggle);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.btnEmail);
			this.Controls.Add(this.lblProgressMessage);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtExceptionMessageLarge);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExceptionReportView";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.tabControl.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picGeneral)).EndInit();
			this.tabAssemblies.ResumeLayout(false);
			this.tabSysInfo.ResumeLayout(false);
			this.lessDetailPanel.ResumeLayout(false);
			this.lessDetailPanel.PerformLayout();
			this.lessDetail_optionsPanel.ResumeLayout(false);
			this.lessDetail_optionsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lessDetail_alertIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewAssemblies;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.TextBox txtUserExplanation;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.TextBox txtApplicationName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TabPage tabExceptions;
        private System.Windows.Forms.TabPage tabAssemblies;
        private System.Windows.Forms.TabPage tabSysInfo;
        private System.Windows.Forms.TreeView treeEnvironment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblProgressMessage;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtExceptionMessage;
        private System.Windows.Forms.PictureBox picGeneral;
        private System.Windows.Forms.Button btnDetailToggle;
        private System.Windows.Forms.TextBox txtExceptionMessageLarge;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel lessDetailPanel;
        private System.Windows.Forms.PictureBox lessDetail_alertIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lessDetail_optionsPanel;
        private System.Windows.Forms.TextBox txtExceptionMessageLarge2;
        private System.Windows.Forms.Label lblContactCompany;
        private System.Windows.Forms.Button btnSimpleEmail;
        private System.Windows.Forms.Button btnSimpleCopy;
        private System.Windows.Forms.Button btnSimpleDetailToggle;
    }
}