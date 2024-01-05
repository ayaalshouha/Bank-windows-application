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

namespace Bank_WindowsForm
{
    public partial class FrmAddClient : Form
    {
        public FrmAddClient()
        {
            InitializeComponent();
        }

        private void _ClearAll()
        {
            txtAccountNumber.Text = string.Empty;
            txtFirstName.Text = string.Empty;   
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtBalance.Text = string.Empty;
            txtPhoneNum.Text = string.Empty;    
            txtPINCode.Text = string.Empty;
        }

        private bool _IsAllFilled()
        {
            if(string.IsNullOrWhiteSpace(txtAccountNumber.Text)
                  || string.IsNullOrWhiteSpace(txtFirstName.Text)
                  || string.IsNullOrWhiteSpace(txtLastName.Text)
                  || string.IsNullOrWhiteSpace(txtPhoneNum.Text)
                  || string.IsNullOrWhiteSpace(txtPINCode.Text)
                  || string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                return false;   
            }
            return true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }


        private bool _IsReadSuccessfully(ref clsClients client)
        {
            client.AccountNumber = txtAccountNumber.Text;
            client.FirstName = txtFirstName.Text;
            client.LastName = txtLastName.Text; 
            client.Email = txtEmail.Text;
            client.Phone = txtPhoneNum.Text;
            client.Balance = Convert.ToDecimal(txtBalance.Text);

            if (Int32.TryParse(txtPINCode.Text, out int Pin))
            {
                client.PinCode = Pin;
                return true;
            }

            return false; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_IsAllFilled())
            {
                if(!clsClients.isExist(txtAccountNumber.Text)) 
                {
                    clsClients Client = new clsClients();

                    if (_IsReadSuccessfully(ref Client))
                    {
                        if (Client.Save())
                        {
                            MessageBox.Show("Client Saved Successfully.","Message Box", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                            _ClearAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong! Try again.", "Message Box", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Account Already Exist!", "Message Box", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please fill all informations.", "Message Box", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            _ClearAll();
            return; 
        }
    }
}
