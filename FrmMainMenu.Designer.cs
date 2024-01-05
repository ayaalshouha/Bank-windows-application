namespace Bank_WindowsForm
{
    partial class FrmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlCurrencies = new System.Windows.Forms.Panel();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.btnFindCuurency = new System.Windows.Forms.Button();
            this.btnCurrenciesList = new System.Windows.Forms.Button();
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.pnlManageUser = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnUsersList = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.pnlManageClients = new System.Windows.Forms.Panel();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnManageClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnClientsList = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.pnlMenu1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMainScreen = new System.Windows.Forms.Panel();
            this.pbMainPanel = new System.Windows.Forms.PictureBox();
            this.ManageClientTimer = new System.Windows.Forms.Timer(this.components);
            this.TransactionsTimer = new System.Windows.Forms.Timer(this.components);
            this.ManageUsersTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrenciesTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlSideBar.SuspendLayout();
            this.pnlCurrencies.SuspendLayout();
            this.pnlManageUser.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlManageClients.SuspendLayout();
            this.pnlMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            resources.ApplyResources(this.pnlSideBar, "pnlSideBar");
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlSideBar.Controls.Add(this.pnlCurrencies);
            this.pnlSideBar.Controls.Add(this.pnlManageUser);
            this.pnlSideBar.Controls.Add(this.pnlTransactions);
            this.pnlSideBar.Controls.Add(this.pnlManageClients);
            this.pnlSideBar.Controls.Add(this.pnlMenu1);
            this.pnlSideBar.Name = "pnlSideBar";
            // 
            // pnlCurrencies
            // 
            this.pnlCurrencies.Controls.Add(this.btnUpdateRate);
            this.pnlCurrencies.Controls.Add(this.btnFindCuurency);
            this.pnlCurrencies.Controls.Add(this.btnCurrenciesList);
            this.pnlCurrencies.Controls.Add(this.btnCurrencies);
            resources.ApplyResources(this.pnlCurrencies, "pnlCurrencies");
            this.pnlCurrencies.Name = "pnlCurrencies";
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateRate.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUpdateRate, "btnUpdateRate");
            this.btnUpdateRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // btnFindCuurency
            // 
            this.btnFindCuurency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindCuurency.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindCuurency.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnFindCuurency, "btnFindCuurency");
            this.btnFindCuurency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindCuurency.Name = "btnFindCuurency";
            this.btnFindCuurency.UseVisualStyleBackColor = true;
            this.btnFindCuurency.Click += new System.EventHandler(this.btnFindCuurency_Click);
            // 
            // btnCurrenciesList
            // 
            this.btnCurrenciesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrenciesList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCurrenciesList.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCurrenciesList, "btnCurrenciesList");
            this.btnCurrenciesList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCurrenciesList.Name = "btnCurrenciesList";
            this.btnCurrenciesList.UseVisualStyleBackColor = true;
            this.btnCurrenciesList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCurrencies.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCurrencies, "btnCurrencies");
            this.btnCurrencies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCurrencies.FlatAppearance.BorderSize = 0;
            this.btnCurrencies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.UseVisualStyleBackColor = false;
            this.btnCurrencies.Click += new System.EventHandler(this.btnCurrencies_Click);
            // 
            // pnlManageUser
            // 
            this.pnlManageUser.Controls.Add(this.btnDeleteUser);
            this.pnlManageUser.Controls.Add(this.btnManageUsers);
            this.pnlManageUser.Controls.Add(this.btnUpdateUser);
            this.pnlManageUser.Controls.Add(this.btnUsersList);
            this.pnlManageUser.Controls.Add(this.btnAddUser);
            this.pnlManageUser.Controls.Add(this.btnFindUser);
            resources.ApplyResources(this.pnlManageUser, "pnlManageUser");
            this.pnlManageUser.Name = "pnlManageUser";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDeleteUser, "btnDeleteUser");
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this.btnManageUsers, "btnManageUsers");
            this.btnManageUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUpdateUser, "btnUpdateUser");
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnUsersList
            // 
            this.btnUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnUsersList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUsersList.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUsersList, "btnUsersList");
            this.btnUsersList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsersList.Name = "btnUsersList";
            this.btnUsersList.UseVisualStyleBackColor = false;
            this.btnUsersList.Click += new System.EventHandler(this.btnUsersList_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddUser, "btnAddUser");
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnFindUser, "btnFindUser");
            this.btnFindUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.UseVisualStyleBackColor = false;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.btnTransfer);
            this.pnlTransactions.Controls.Add(this.btnTransactions);
            this.pnlTransactions.Controls.Add(this.btnWithdraw);
            this.pnlTransactions.Controls.Add(this.btnDeposite);
            resources.ApplyResources(this.pnlTransactions, "pnlTransactions");
            this.pnlTransactions.Name = "pnlTransactions";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTransfer, "btnTransfer");
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTransactions, "btnTransactions");
            this.btnTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnWithdraw, "btnWithdraw");
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposite
            // 
            this.btnDeposite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnDeposite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeposite.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDeposite, "btnDeposite");
            this.btnDeposite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.UseVisualStyleBackColor = false;
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // pnlManageClients
            // 
            this.pnlManageClients.Controls.Add(this.btnDeleteClient);
            this.pnlManageClients.Controls.Add(this.btnManageClient);
            this.pnlManageClients.Controls.Add(this.btnUpdateClient);
            this.pnlManageClients.Controls.Add(this.btnClientsList);
            this.pnlManageClients.Controls.Add(this.btnAddNewClient);
            this.pnlManageClients.Controls.Add(this.btnFindClient);
            resources.ApplyResources(this.pnlManageClients, "pnlManageClients");
            this.pnlManageClients.Name = "pnlManageClients";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnDeleteClient, "btnDeleteClient");
            this.btnDeleteClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnManageClient
            // 
            this.btnManageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnManageClient.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnManageClient, "btnManageClient");
            this.btnManageClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnManageClient.FlatAppearance.BorderSize = 0;
            this.btnManageClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManageClient.Name = "btnManageClient";
            this.btnManageClient.UseVisualStyleBackColor = false;
            this.btnManageClient.Click += new System.EventHandler(this.btnManageClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUpdateClient, "btnUpdateClient");
            this.btnUpdateClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnClientsList
            // 
            this.btnClientsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientsList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientsList.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClientsList, "btnClientsList");
            this.btnClientsList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientsList.Name = "btnClientsList";
            this.btnClientsList.UseVisualStyleBackColor = true;
            this.btnClientsList.Click += new System.EventHandler(this.btnClientsList_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddNewClient, "btnAddNewClient");
            this.btnAddNewClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFindClient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnFindClient, "btnFindClient");
            this.btnFindClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click_1);
            // 
            // pnlMenu1
            // 
            this.pnlMenu1.Controls.Add(this.label1);
            this.pnlMenu1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.pnlMenu1, "pnlMenu1");
            this.pnlMenu1.Name = "pnlMenu1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblHeader);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Name = "lblHeader";
            // 
            // pnlMainScreen
            // 
            this.pnlMainScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainScreen.Controls.Add(this.pbMainPanel);
            resources.ApplyResources(this.pnlMainScreen, "pnlMainScreen");
            this.pnlMainScreen.Name = "pnlMainScreen";
            // 
            // pbMainPanel
            // 
            resources.ApplyResources(this.pbMainPanel, "pbMainPanel");
            this.pbMainPanel.Name = "pbMainPanel";
            this.pbMainPanel.TabStop = false;
            // 
            // ManageClientTimer
            // 
            this.ManageClientTimer.Tick += new System.EventHandler(this.ManageClientTimer_Tick);
            // 
            // TransactionsTimer
            // 
            this.TransactionsTimer.Tick += new System.EventHandler(this.TransactionsTimer_Tick);
            // 
            // ManageUsersTimer
            // 
            this.ManageUsersTimer.Tick += new System.EventHandler(this.ManageUsersTimer_Tick);
            // 
            // CurrenciesTimer
            // 
            this.CurrenciesTimer.Tick += new System.EventHandler(this.CurrenciesTimer_Tick);
            // 
            // FrmMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainScreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "FrmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlCurrencies.ResumeLayout(false);
            this.pnlManageUser.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlManageClients.ResumeLayout(false);
            this.pnlMenu1.ResumeLayout(false);
            this.pnlMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMainScreen;
        private System.Windows.Forms.Button btnClientsList;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnUsersList;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnFindUser;
        private System.Windows.Forms.Timer ManageClientTimer;
        private System.Windows.Forms.Timer TransactionsTimer;
        private System.Windows.Forms.Timer ManageUsersTimer;
        private System.Windows.Forms.Timer CurrenciesTimer;
        private System.Windows.Forms.Button btnManageClient;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposite;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnCurrencies;
        private System.Windows.Forms.Panel pnlMenu1;
        private System.Windows.Forms.Panel pnlManageClients;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Panel pnlManageUser;
        private System.Windows.Forms.Panel pnlCurrencies;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.Button btnFindCuurency;
        private System.Windows.Forms.Button btnCurrenciesList;
        private System.Windows.Forms.PictureBox pbMainPanel;
    }
}