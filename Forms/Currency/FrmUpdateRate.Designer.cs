namespace Bank_WindowsForm.Forms.Currency
{
    partial class FrmUpdateRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateRate));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.updownRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.updownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(778, 345);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(314, 82);
            this.btnUpdate.TabIndex = 92;
            this.btnUpdate.Text = "Update Rate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updownRate
            // 
            this.updownRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updownRate.Enabled = false;
            this.updownRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updownRate.Location = new System.Drawing.Point(778, 250);
            this.updownRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updownRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updownRate.Name = "updownRate";
            this.updownRate.Size = new System.Drawing.Size(314, 40);
            this.updownRate.TabIndex = 91;
            this.updownRate.ValueChanged += new System.EventHandler(this.updownRate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(778, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "New Rate";
            // 
            // tbRate
            // 
            this.tbRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.Location = new System.Drawing.Point(778, 153);
            this.tbRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.Size = new System.Drawing.Size(312, 35);
            this.tbRate.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(778, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 29);
            this.label9.TabIndex = 84;
            this.label9.Text = "Current Rate";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(409, 183);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 54);
            this.btnFind.TabIndex = 87;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(93, 195);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(312, 35);
            this.tbInput.TabIndex = 86;
            // 
            // lbInput
            // 
            this.lbInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(87, 159);
            this.lbInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(72, 29);
            this.lbInput.TabIndex = 85;
            this.lbInput.Text = "Code";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 82);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 29);
            this.label14.TabIndex = 82;
            this.label14.Text = "Find Currency by : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Code",
            "Country"});
            this.comboBox1.Location = new System.Drawing.Point(324, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 34);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 93;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmUpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.updownRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateRate";
            this.Text = "FrmUpdateRate";
            this.Load += new System.EventHandler(this.FrmUpdateRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown updownRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}