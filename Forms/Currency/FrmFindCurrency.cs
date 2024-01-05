using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace Bank_WindowsForm.Forms.Currency
{
    public partial class FrmFindCurrency : Form
    {
        clsCurrencies _Currency; 
        
        public FrmFindCurrency()
        {
            InitializeComponent();
           
        }

        private void FrmFindCurrency_Load(object sender, EventArgs e)
        {
            tbInput.Enabled = false;
            groupBox1.Enabled = false;
            comboBox1.SelectedIndex = 0;
            lbInput.Text = comboBox1.Text; 
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show($"Please enter {comboBox1.Text}.", "Message Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if(comboBox1.SelectedItem.ToString() == "Code")
            {
                _Currency = clsCurrencies.FindByCode(tbInput.Text);

                if(_Currency != null)
                {
                    groupBox1.Enabled = true;
                    tbCountry.Text = _Currency.Country;
                    tbCode.Text = _Currency.Code;
                    tbName.Text = _Currency.Name;
                    tbRate.Text = _Currency.Rate.ToString();
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
                    groupBox1.Enabled = true;
                    tbCountry.Text = _Currency.Country;
                    tbCode.Text = _Currency.Code;
                    tbName.Text = _Currency.Name;
                    tbRate.Text = _Currency.Rate.ToString();
                }
                else
                {
                    MessageBox.Show("Currency NOT Found!", "Message Box", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

          
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

    }
}
