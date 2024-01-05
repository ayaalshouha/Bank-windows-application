namespace Bank_WindowsForm.Forms.Transactions
{
    partial class FrmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransfer));
            this.gbFromClient = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbToClient = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBalance2 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.txtFirstName2 = new System.Windows.Forms.TextBox();
            this.txtAccount1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFind1 = new System.Windows.Forms.Button();
            this.btnFind2 = new System.Windows.Forms.Button();
            this.txtAccount2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.gbFromClient.SuspendLayout();
            this.gbToClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFromClient
            // 
            this.gbFromClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbFromClient.Controls.Add(this.label5);
            this.gbFromClient.Controls.Add(this.label4);
            this.gbFromClient.Controls.Add(this.label3);
            this.gbFromClient.Controls.Add(this.label2);
            this.gbFromClient.Controls.Add(this.label1);
            this.gbFromClient.Controls.Add(this.txtAccountBalance);
            this.gbFromClient.Controls.Add(this.txtPhone);
            this.gbFromClient.Controls.Add(this.txtEmail);
            this.gbFromClient.Controls.Add(this.txtLastname);
            this.gbFromClient.Controls.Add(this.txtFirstName);
            this.gbFromClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFromClient.Location = new System.Drawing.Point(57, 74);
            this.gbFromClient.Name = "gbFromClient";
            this.gbFromClient.Size = new System.Drawing.Size(356, 532);
            this.gbFromClient.TabIndex = 0;
            this.gbFromClient.TabStop = false;
            this.gbFromClient.Text = "From";
            this.gbFromClient.Enter += new System.EventHandler(this.gbFromClient_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(21, 385);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.ReadOnly = true;
            this.txtAccountBalance.Size = new System.Drawing.Size(223, 39);
            this.txtAccountBalance.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(21, 309);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(223, 39);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(223, 39);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(21, 157);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.ReadOnly = true;
            this.txtLastname.Size = new System.Drawing.Size(223, 39);
            this.txtLastname.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(21, 81);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(223, 39);
            this.txtFirstName.TabIndex = 0;
            // 
            // gbToClient
            // 
            this.gbToClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbToClient.Controls.Add(this.label9);
            this.gbToClient.Controls.Add(this.label10);
            this.gbToClient.Controls.Add(this.label11);
            this.gbToClient.Controls.Add(this.label12);
            this.gbToClient.Controls.Add(this.label13);
            this.gbToClient.Controls.Add(this.txtBalance2);
            this.gbToClient.Controls.Add(this.txtPhone2);
            this.gbToClient.Controls.Add(this.txtEmail2);
            this.gbToClient.Controls.Add(this.txtLastName2);
            this.gbToClient.Controls.Add(this.txtFirstName2);
            this.gbToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToClient.Location = new System.Drawing.Point(941, 74);
            this.gbToClient.Name = "gbToClient";
            this.gbToClient.Size = new System.Drawing.Size(356, 532);
            this.gbToClient.TabIndex = 1;
            this.gbToClient.TabStop = false;
            this.gbToClient.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Account Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "First Name";
            // 
            // txtBalance2
            // 
            this.txtBalance2.Location = new System.Drawing.Point(36, 393);
            this.txtBalance2.Name = "txtBalance2";
            this.txtBalance2.ReadOnly = true;
            this.txtBalance2.Size = new System.Drawing.Size(223, 39);
            this.txtBalance2.TabIndex = 16;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(36, 315);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.ReadOnly = true;
            this.txtPhone2.Size = new System.Drawing.Size(223, 39);
            this.txtPhone2.TabIndex = 15;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(36, 237);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.ReadOnly = true;
            this.txtEmail2.Size = new System.Drawing.Size(223, 39);
            this.txtEmail2.TabIndex = 14;
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(36, 159);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.ReadOnly = true;
            this.txtLastName2.Size = new System.Drawing.Size(223, 39);
            this.txtLastName2.TabIndex = 12;
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Location = new System.Drawing.Point(36, 81);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.ReadOnly = true;
            this.txtFirstName2.Size = new System.Drawing.Size(223, 39);
            this.txtFirstName2.TabIndex = 11;
            // 
            // txtAccount1
            // 
            this.txtAccount1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccount1.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount1.Location = new System.Drawing.Point(470, 121);
            this.txtAccount1.Multiline = true;
            this.txtAccount1.Name = "txtAccount1";
            this.txtAccount1.Size = new System.Drawing.Size(294, 56);
            this.txtAccount1.TabIndex = 5;
            this.txtAccount1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "From Account Number:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "To Account Number:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(470, 450);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(367, 48);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnFind1
            // 
            this.btnFind1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind1.BackColor = System.Drawing.Color.Transparent;
            this.btnFind1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind1.FlatAppearance.BorderSize = 0;
            this.btnFind1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind1.ForeColor = System.Drawing.Color.Transparent;
            this.btnFind1.Image = ((System.Drawing.Image)(resources.GetObject("btnFind1.Image")));
            this.btnFind1.Location = new System.Drawing.Point(767, 119);
            this.btnFind1.Name = "btnFind1";
            this.btnFind1.Size = new System.Drawing.Size(59, 58);
            this.btnFind1.TabIndex = 16;
            this.btnFind1.UseVisualStyleBackColor = false;
            this.btnFind1.Click += new System.EventHandler(this.btnFind1_Click);
            // 
            // btnFind2
            // 
            this.btnFind2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind2.BackColor = System.Drawing.Color.Transparent;
            this.btnFind2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind2.FlatAppearance.BorderSize = 0;
            this.btnFind2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind2.ForeColor = System.Drawing.Color.Transparent;
            this.btnFind2.Image = ((System.Drawing.Image)(resources.GetObject("btnFind2.Image")));
            this.btnFind2.Location = new System.Drawing.Point(770, 294);
            this.btnFind2.Name = "btnFind2";
            this.btnFind2.Size = new System.Drawing.Size(61, 57);
            this.btnFind2.TabIndex = 17;
            this.btnFind2.UseVisualStyleBackColor = false;
            this.btnFind2.Click += new System.EventHandler(this.btnFind2_Click);
            // 
            // txtAccount2
            // 
            this.txtAccount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccount2.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount2.Location = new System.Drawing.Point(470, 294);
            this.txtAccount2.Multiline = true;
            this.txtAccount2.Name = "txtAccount2";
            this.txtAccount2.Size = new System.Drawing.Size(294, 56);
            this.txtAccount2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Amount To Transfer:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.ImageKey = "(none)";
            this.btnTransfer.Location = new System.Drawing.Point(531, 533);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(233, 73);
            this.btnTransfer.TabIndex = 20;
            this.btnTransfer.Text = "     Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 696);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtAccount2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFind2);
            this.Controls.Add(this.txtAccount1);
            this.Controls.Add(this.btnFind1);
            this.Controls.Add(this.gbToClient);
            this.Controls.Add(this.gbFromClient);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransfer";
            this.Text = "FrmTransfer";
            this.Load += new System.EventHandler(this.FrmTransfer_Load);
            this.gbFromClient.ResumeLayout(false);
            this.gbFromClient.PerformLayout();
            this.gbToClient.ResumeLayout(false);
            this.gbToClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFromClient;
        private System.Windows.Forms.TextBox txtAccount1;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox gbToClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnFind1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBalance2;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.TextBox txtFirstName2;
        private System.Windows.Forms.Button btnFind2;
        private System.Windows.Forms.TextBox txtAccount2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTransfer;
    }
}