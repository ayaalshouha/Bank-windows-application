namespace Bank_WindowsForm
{
    partial class FrmAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClient));
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClientCardd = new System.Windows.Forms.GroupBox();
            this.txtPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.txtPINCode = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbClientCardd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(17, 66);
            this.txtAccountNumber.MaxLength = 5;
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(257, 26);
            this.txtAccountNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number";
            // 
            // gbClientCardd
            // 
            this.gbClientCardd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbClientCardd.Controls.Add(this.txtPhoneNum);
            this.gbClientCardd.Controls.Add(this.txtPINCode);
            this.gbClientCardd.Controls.Add(this.pictureBox1);
            this.gbClientCardd.Controls.Add(this.btnClearAll);
            this.gbClientCardd.Controls.Add(this.label7);
            this.gbClientCardd.Controls.Add(this.btnSave);
            this.gbClientCardd.Controls.Add(this.txtBalance);
            this.gbClientCardd.Controls.Add(this.label6);
            this.gbClientCardd.Controls.Add(this.label5);
            this.gbClientCardd.Controls.Add(this.txtLastName);
            this.gbClientCardd.Controls.Add(this.label4);
            this.gbClientCardd.Controls.Add(this.txtEmail);
            this.gbClientCardd.Controls.Add(this.label3);
            this.gbClientCardd.Controls.Add(this.txtFirstName);
            this.gbClientCardd.Controls.Add(this.label2);
            this.gbClientCardd.Controls.Add(this.txtAccountNumber);
            this.gbClientCardd.Controls.Add(this.label1);
            this.gbClientCardd.Location = new System.Drawing.Point(124, 35);
            this.gbClientCardd.Name = "gbClientCardd";
            this.gbClientCardd.Size = new System.Drawing.Size(972, 616);
            this.gbClientCardd.TabIndex = 2;
            this.gbClientCardd.TabStop = false;
            this.gbClientCardd.Text = "Fill Information";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(378, 166);
            this.txtPhoneNum.Mask = "(999) 000-0000";
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(257, 26);
            this.txtPhoneNum.TabIndex = 5;
            // 
            // txtPINCode
            // 
            this.txtPINCode.Location = new System.Drawing.Point(378, 66);
            this.txtPINCode.Mask = "0000";
            this.txtPINCode.Name = "txtPINCode";
            this.txtPINCode.Size = new System.Drawing.Size(257, 26);
            this.txtPINCode.TabIndex = 4;
            this.txtPINCode.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(690, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearAll.Location = new System.Drawing.Point(498, 464);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(202, 93);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "PIN Code";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(740, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(202, 93);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(378, 266);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(257, 26);
            this.txtBalance.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(17, 266);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(257, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 366);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(17, 166);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(257, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddClient
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gbClientCardd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddClient";
            this.Text = "FrmAddClient";
            this.gbClientCardd.ResumeLayout(false);
            this.gbClientCardd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbClientCardd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txtPhoneNum;
        private System.Windows.Forms.MaskedTextBox txtPINCode;
    }
}