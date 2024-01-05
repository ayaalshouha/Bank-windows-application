namespace Bank_WindowsForm.Forms.User
{
    partial class FrmFindUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindUser));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbClientCard = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUserID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbClientCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(500, 86);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 46);
            this.btnFind.TabIndex = 21;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(712, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // gbClientCard
            // 
            this.gbClientCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbClientCard.Controls.Add(this.pictureBox2);
            this.gbClientCard.Controls.Add(this.label8);
            this.gbClientCard.Controls.Add(this.btnUserID);
            this.gbClientCard.Controls.Add(this.label7);
            this.gbClientCard.Controls.Add(this.label6);
            this.gbClientCard.Controls.Add(this.label5);
            this.gbClientCard.Controls.Add(this.label4);
            this.gbClientCard.Controls.Add(this.label3);
            this.gbClientCard.Controls.Add(this.label2);
            this.gbClientCard.Controls.Add(this.txtLastName);
            this.gbClientCard.Controls.Add(this.txtPermissions);
            this.gbClientCard.Controls.Add(this.txtEmail);
            this.gbClientCard.Controls.Add(this.txtPassword);
            this.gbClientCard.Controls.Add(this.txtPhone);
            this.gbClientCard.Controls.Add(this.txtFistName);
            this.gbClientCard.Location = new System.Drawing.Point(123, 176);
            this.gbClientCard.Name = "gbClientCard";
            this.gbClientCard.Size = new System.Drawing.Size(954, 433);
            this.gbClientCard.TabIndex = 22;
            this.gbClientCard.TabStop = false;
            this.gbClientCard.Text = "Client Card";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // btnUserID
            // 
            this.btnUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserID.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUserID.Enabled = false;
            this.btnUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserID.Location = new System.Drawing.Point(712, 289);
            this.btnUserID.Name = "btnUserID";
            this.btnUserID.Size = new System.Drawing.Size(215, 102);
            this.btnUserID.TabIndex = 10;
            this.btnUserID.Text = "ID";
            this.btnUserID.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Permissions";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 146);
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
            this.label4.Location = new System.Drawing.Point(427, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 146);
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
            this.label2.Location = new System.Drawing.Point(54, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(432, 78);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(210, 35);
            this.txtLastName.TabIndex = 3;
            // 
            // txtPermissions
            // 
            this.txtPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermissions.Location = new System.Drawing.Point(432, 260);
            this.txtPermissions.Multiline = true;
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.ReadOnly = true;
            this.txtPermissions.Size = new System.Drawing.Size(210, 35);
            this.txtPermissions.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(59, 174);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(210, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(59, 260);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(210, 35);
            this.txtPassword.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(432, 174);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(210, 35);
            this.txtPhone.TabIndex = 5;
            // 
            // txtFistName
            // 
            this.txtFistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFistName.Location = new System.Drawing.Point(59, 78);
            this.txtFistName.Multiline = true;
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.ReadOnly = true;
            this.txtFistName.Size = new System.Drawing.Size(210, 35);
            this.txtFistName.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(233, 86);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(261, 46);
            this.txtUsername.TabIndex = 20;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // FrmFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gbClientCard);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFindUser";
            this.Text = "FrmFindUser";
            this.Load += new System.EventHandler(this.FrmFindUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbClientCard.ResumeLayout(false);
            this.gbClientCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbClientCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtUsername;
    }
}