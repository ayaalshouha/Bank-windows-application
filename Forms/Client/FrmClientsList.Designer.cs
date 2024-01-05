namespace Bank_WindowsForm
{
    partial class FrmClientsList
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
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.AllowUserToOrderColumns = true;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientList.Location = new System.Drawing.Point(0, 0);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.RowHeadersWidth = 62;
            this.dgvClientList.RowTemplate.Height = 28;
            this.dgvClientList.Size = new System.Drawing.Size(1224, 699);
            this.dgvClientList.TabIndex = 14;
            // 
            // FrmClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 699);
            this.Controls.Add(this.dgvClientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientsList";
            this.Text = "FrmClientsList";
            this.Load += new System.EventHandler(this.FrmClientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClientList;
    }
}