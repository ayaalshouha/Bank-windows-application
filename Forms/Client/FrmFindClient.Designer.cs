namespace Bank_WindowsForm
{
    partial class FrmFindClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindClient));
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.txtPINCode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.gbClientCard = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClientID = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClientCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(240, 99);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(261, 46);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(58, 258);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(210, 35);
            this.txtBalance.TabIndex = 6;
            // 
            // txtFistName
            // 
            this.txtFistName.Location = new System.Drawing.Point(58, 76);
            this.txtFistName.Multiline = true;
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.ReadOnly = true;
            this.txtFistName.Size = new System.Drawing.Size(210, 35);
            this.txtFistName.TabIndex = 2;
            // 
            // txtPINCode
            // 
            this.txtPINCode.Location = new System.Drawing.Point(431, 258);
            this.txtPINCode.Multiline = true;
            this.txtPINCode.Name = "txtPINCode";
            this.txtPINCode.ReadOnly = true;
            this.txtPINCode.Size = new System.Drawing.Size(210, 35);
            this.txtPINCode.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(431, 172);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(210, 35);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 172);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(210, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(431, 76);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(210, 35);
            this.txtLastName.TabIndex = 3;
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
            this.gbClientCard.Controls.Add(this.label2);
            this.gbClientCard.Controls.Add(this.txtLastName);
            this.gbClientCard.Controls.Add(this.txtPINCode);
            this.gbClientCard.Controls.Add(this.txtEmail);
            this.gbClientCard.Controls.Add(this.txtBalance);
            this.gbClientCard.Controls.Add(this.txtPhone);
            this.gbClientCard.Controls.Add(this.txtFistName);
            this.gbClientCard.Location = new System.Drawing.Point(123, 176);
            this.gbClientCard.Name = "gbClientCard";
            this.gbClientCard.Size = new System.Drawing.Size(954, 433);
            this.gbClientCard.TabIndex = 7;
            this.gbClientCard.TabStop = false;
            this.gbClientCard.Text = "Client Card";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(706, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // btnClientID
            // 
            this.btnClientID.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClientID.Enabled = false;
            this.btnClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientID.Location = new System.Drawing.Point(711, 287);
            this.btnClientID.Name = "btnClientID";
            this.btnClientID.Size = new System.Drawing.Size(215, 102);
            this.btnClientID.TabIndex = 10;
            this.btnClientID.Text = "ID";
            this.btnClientID.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "PIN Code";
            // 
            // label5
            // 
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
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(506, 99);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 46);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Account Number";
            // 
            // FrmFindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.gbClientCard);
            this.Controls.Add(this.txtAccountNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFindClient";
            this.Text = "FrmFindClient";
            this.Load += new System.EventHandler(this.FrmFindClient_Load);
            this.gbClientCard.ResumeLayout(false);
            this.gbClientCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtPINCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox gbClientCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClientID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}