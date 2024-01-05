namespace Bank_WindowsForm.Forms.User
{
    partial class FrmDeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteUser));
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbClientCard = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClientID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbClientCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(903, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 74);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username";
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
            this.btnFind.Location = new System.Drawing.Point(510, 105);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 46);
            this.btnFind.TabIndex = 23;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbClientCard
            // 
            this.gbClientCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbClientCard.Controls.Add(this.pictureBox1);
            this.gbClientCard.Controls.Add(this.label8);
            this.gbClientCard.Controls.Add(this.btnClientID);
            this.gbClientCard.Controls.Add(this.label7);
            this.gbClientCard.Controls.Add(this.label6);
            this.gbClientCard.Controls.Add(this.label5);
            this.gbClientCard.Controls.Add(this.label4);
            this.gbClientCard.Controls.Add(this.label3);
            this.gbClientCard.Controls.Add(this.label9);
            this.gbClientCard.Controls.Add(this.txtLastName);
            this.gbClientCard.Controls.Add(this.txtPermissions);
            this.gbClientCard.Controls.Add(this.txtEmail);
            this.gbClientCard.Controls.Add(this.txtPass);
            this.gbClientCard.Controls.Add(this.txtPhone);
            this.gbClientCard.Controls.Add(this.txtFistName);
            this.gbClientCard.Location = new System.Drawing.Point(123, 185);
            this.gbClientCard.Name = "gbClientCard";
            this.gbClientCard.Size = new System.Drawing.Size(954, 433);
            this.gbClientCard.TabIndex = 24;
            this.gbClientCard.TabStop = false;
            this.gbClientCard.Text = "Client Card";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(719, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // btnClientID
            // 
            this.btnClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientID.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClientID.Enabled = false;
            this.btnClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientID.Location = new System.Drawing.Point(714, 290);
            this.btnClientID.Name = "btnClientID";
            this.btnClientID.Size = new System.Drawing.Size(215, 102);
            this.btnClientID.TabIndex = 10;
            this.btnClientID.Text = "ID";
            this.btnClientID.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 230);
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
            this.label6.Location = new System.Drawing.Point(426, 230);
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
            this.label5.Location = new System.Drawing.Point(426, 144);
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
            this.label4.Location = new System.Drawing.Point(426, 48);
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
            this.label3.Location = new System.Drawing.Point(53, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(431, 76);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(210, 35);
            this.txtLastName.TabIndex = 3;
            // 
            // txtPermissions
            // 
            this.txtPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermissions.Location = new System.Drawing.Point(431, 258);
            this.txtPermissions.MaxLength = 4;
            this.txtPermissions.Multiline = true;
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.ReadOnly = true;
            this.txtPermissions.Size = new System.Drawing.Size(210, 35);
            this.txtPermissions.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(58, 172);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(210, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(58, 258);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(210, 35);
            this.txtPass.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(431, 172);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(210, 35);
            this.txtPhone.TabIndex = 5;
            // 
            // txtFistName
            // 
            this.txtFistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFistName.Location = new System.Drawing.Point(58, 76);
            this.txtFistName.MaxLength = 15;
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
            this.txtUsername.Location = new System.Drawing.Point(240, 108);
            this.txtUsername.MaxLength = 5;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(261, 46);
            this.txtUsername.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(158, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 21;
            // 
            // FrmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gbClientCard);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeleteUser";
            this.Text = "FrmDeleteUser";
            this.Load += new System.EventHandler(this.FrmDeleteUser_Load);
            this.gbClientCard.ResumeLayout(false);
            this.gbClientCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox gbClientCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClientID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox textBox1;
    }
}