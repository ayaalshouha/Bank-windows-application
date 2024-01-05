using BankBuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Bank_WindowsForm.Forms.Currency
{
    public partial class FrmUpdateRate : Form
    {
        clsCurrencies _Currency; 
        public FrmUpdateRate()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            tbInput.Text = string.Empty;
            tbInput.Enabled = false;
            comboBox1.SelectedIndex = 0;
            btnUpdate.Enabled = false;
            lbInput.Text = comboBox1.Text;
            tbRate.Enabled = false;
            updownRate.Enabled = false;
            this.AcceptButton = btnFind;
            
        }

        private void FrmUpdateRate_Load(object sender, EventArgs e)
        {
            _Reset();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;

            if (comboBox1.SelectedItem.ToString() == "Code")
            {
                lbInput.Text = "Code";
            }
            else
            {
                lbInput.Text = "Country";
            }

            tbInput.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show($"Please enter {comboBox1.Text}.", "Message Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Code")
            {
                _Currency = clsCurrencies.FindByCode(tbInput.Text);

                if (_Currency != null)
                {
                    tbRate.Enabled = true;
                    tbRate.Text = _Currency.Rate.ToString();
                    updownRate.Enabled = true;
                    btnUpdate.Enabled = true;
                    this.AcceptButton =
                        btnUpdate;
                }
                else
                {
                    MessageBox.Show("Currency NOT Found!", "Message Box", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                _Currency = clsCurrencies.FindByCountry(tbInput.Text);

                if (_Currency != null)
                {
                    tbRate.Enabled = true;
                    tbRate.Text = _Currency.Rate.ToString();
                    updownRate.Enabled = true;
                    btnUpdate.Enabled = true;
                    this.AcceptButton = 
                        btnUpdate;

                }
                else
                {
                    MessageBox.Show("Currency NOT Found!", "Message Box", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void updownRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(updownRate.Value == 0)
            {
                MessageBox.Show("Enter new rate.","Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                

                return;
            }

            if (_Currency.UpdateRate(updownRate.Value))
            {
                MessageBox.Show("Rate updatted successfully.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

               
            }

            MessageBox.Show("Something went wrong.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            _Reset();

            return;

        }
    }
}
