namespace Bank_WindowsForm.Forms.Currency
{
    partial class FrmFindCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindCurrency));
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(73, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 29);
            this.label14.TabIndex = 28;
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
            this.comboBox1.Location = new System.Drawing.Point(311, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 34);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tbRate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbCountry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(711, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 594);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency Information";
            // 
            // tbRate
            // 
            this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRate.Location = new System.Drawing.Point(30, 490);
            this.tbRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.Size = new System.Drawing.Size(312, 35);
            this.tbRate.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 29);
            this.label9.TabIndex = 43;
            this.label9.Text = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Country";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(24, 354);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(312, 35);
            this.tbName.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "Name";
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.Location = new System.Drawing.Point(24, 216);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(312, 35);
            this.tbCode.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 29);
            this.label13.TabIndex = 41;
            this.label13.Text = "Code";
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(24, 96);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(312, 35);
            this.tbCountry.TabIndex = 37;
            // 
            // tbInput
            // 
            this.tbInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(79, 224);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(312, 44);
            this.tbInput.TabIndex = 60;
            // 
            // lbInput
            // 
            this.lbInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(73, 188);
            this.lbInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(72, 29);
            this.lbInput.TabIndex = 59;
            this.lbInput.Text = "Code";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(394, 221);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(64, 49);
            this.btnFind.TabIndex = 61;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FrmFindCurrency
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 696);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFindCurrency";
            this.Text = "FrmFindCurrency";
            this.Load += new System.EventHandler(this.FrmFindCurrency_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCountry;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btnFind;
    }
}