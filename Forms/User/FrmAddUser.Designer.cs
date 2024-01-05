namespace Bank_WindowsForm.Forms.User
{
    partial class FrmAddUser
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
            this.btnFind = new System.Windows.Forms.Button();
            this.gbClientCard = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.chbDeleteUser = new System.Windows.Forms.CheckBox();
            this.chbFindUser = new System.Windows.Forms.CheckBox();
            this.chbUpdateUser = new System.Windows.Forms.CheckBox();
            this.ChbAddUser = new System.Windows.Forms.CheckBox();
            this.chbUserList = new System.Windows.Forms.CheckBox();
            this.chbDleteClient = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbClientCard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Location = new System.Drawing.Point(836, 75);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(282, 74);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Save";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbClientCard
            // 
            this.gbClientCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbClientCard.Controls.Add(this.label7);
            this.gbClientCard.Controls.Add(this.label1);
            this.gbClientCard.Controls.Add(this.label5);
            this.gbClientCard.Controls.Add(this.label4);
            this.gbClientCard.Controls.Add(this.txtUsername);
            this.gbClientCard.Controls.Add(this.label3);
            this.gbClientCard.Controls.Add(this.label2);
            this.gbClientCard.Controls.Add(this.txtLastName);
            this.gbClientCard.Controls.Add(this.txtEmail);
            this.gbClientCard.Controls.Add(this.txtPassword);
            this.gbClientCard.Controls.Add(this.txtPhone);
            this.gbClientCard.Controls.Add(this.txtFistName);
            this.gbClientCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientCard.Location = new System.Drawing.Point(23, 35);
            this.gbClientCard.Name = "gbClientCard";
            this.gbClientCard.Size = new System.Drawing.Size(421, 583);
            this.gbClientCard.TabIndex = 25;
            this.gbClientCard.TabStop = false;
            this.gbClientCard.Text = "User Card";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(29, 79);
            this.txtUsername.MaxLength = 10;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 35);
            this.txtUsername.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(25, 246);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 35);
            this.txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(25, 328);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(25, 483);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 35);
            this.txtPassword.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(25, 406);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(210, 35);
            this.txtPhone.TabIndex = 5;
            // 
            // txtFistName
            // 
            this.txtFistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFistName.Location = new System.Drawing.Point(25, 167);
            this.txtFistName.MaxLength = 15;
            this.txtFistName.Multiline = true;
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Size = new System.Drawing.Size(210, 35);
            this.txtFistName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.chbDeleteUser);
            this.groupBox1.Controls.Add(this.chbFindUser);
            this.groupBox1.Controls.Add(this.chbUpdateUser);
            this.groupBox1.Controls.Add(this.ChbAddUser);
            this.groupBox1.Controls.Add(this.chbUserList);
            this.groupBox1.Controls.Add(this.chbDleteClient);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(500, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 383);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // checkBox12
            // 
            this.checkBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Enabled = false;
            this.checkBox12.Location = new System.Drawing.Point(25, 309);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(203, 29);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "Currencies Access";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Enabled = false;
            this.checkBox11.Location = new System.Drawing.Point(25, 258);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(221, 29);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Transactions Access";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // chbDeleteUser
            // 
            this.chbDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbDeleteUser.AutoSize = true;
            this.chbDeleteUser.Location = new System.Drawing.Point(276, 258);
            this.chbDeleteUser.Name = "chbDeleteUser";
            this.chbDeleteUser.Size = new System.Drawing.Size(210, 29);
            this.chbDeleteUser.TabIndex = 9;
            this.chbDeleteUser.Text = "Delete User Access";
            this.chbDeleteUser.UseVisualStyleBackColor = true;
            // 
            // chbFindUser
            // 
            this.chbFindUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbFindUser.AutoSize = true;
            this.chbFindUser.Location = new System.Drawing.Point(276, 207);
            this.chbFindUser.Name = "chbFindUser";
            this.chbFindUser.Size = new System.Drawing.Size(192, 29);
            this.chbFindUser.TabIndex = 8;
            this.chbFindUser.Text = "Find User Access";
            this.chbFindUser.UseVisualStyleBackColor = true;
            // 
            // chbUpdateUser
            // 
            this.chbUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbUpdateUser.AutoSize = true;
            this.chbUpdateUser.Location = new System.Drawing.Point(276, 156);
            this.chbUpdateUser.Name = "chbUpdateUser";
            this.chbUpdateUser.Size = new System.Drawing.Size(217, 29);
            this.chbUpdateUser.TabIndex = 7;
            this.chbUpdateUser.Text = "Update User Access";
            this.chbUpdateUser.UseVisualStyleBackColor = true;
            // 
            // ChbAddUser
            // 
            this.ChbAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChbAddUser.AutoSize = true;
            this.ChbAddUser.Location = new System.Drawing.Point(276, 105);
            this.ChbAddUser.Name = "ChbAddUser";
            this.ChbAddUser.Size = new System.Drawing.Size(190, 29);
            this.ChbAddUser.TabIndex = 6;
            this.ChbAddUser.Text = "Add User Access";
            this.ChbAddUser.UseVisualStyleBackColor = true;
            // 
            // chbUserList
            // 
            this.chbUserList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbUserList.AutoSize = true;
            this.chbUserList.Location = new System.Drawing.Point(272, 54);
            this.chbUserList.Name = "chbUserList";
            this.chbUserList.Size = new System.Drawing.Size(194, 29);
            this.chbUserList.TabIndex = 5;
            this.chbUserList.Text = "Users List Access";
            this.chbUserList.UseVisualStyleBackColor = true;
            // 
            // chbDleteClient
            // 
            this.chbDleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbDleteClient.AutoSize = true;
            this.chbDleteClient.Location = new System.Drawing.Point(276, 309);
            this.chbDleteClient.Name = "chbDleteClient";
            this.chbDleteClient.Size = new System.Drawing.Size(219, 29);
            this.chbDleteClient.TabIndex = 4;
            this.chbDleteClient.Text = "Delete Client Access";
            this.chbDleteClient.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(25, 207);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(201, 29);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Find Client Access";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(25, 156);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(226, 29);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Update Client Access";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(25, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(199, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Add Client Access";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(25, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(203, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Clients List Access";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gbClientCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUser";
            this.Text = "FrmAddUser";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.gbClientCard.ResumeLayout(false);
            this.gbClientCard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbClientCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox chbDeleteUser;
        private System.Windows.Forms.CheckBox chbFindUser;
        private System.Windows.Forms.CheckBox chbUpdateUser;
        private System.Windows.Forms.CheckBox ChbAddUser;
        private System.Windows.Forms.CheckBox chbUserList;
        private System.Windows.Forms.CheckBox chbDleteClient;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}