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

namespace Bank_WindowsForm.Forms.Transactions
{
    public partial class FrmWithraw : Form
    {
        clsClients _Client; 
        public FrmWithraw()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            gbClientCard.Enabled = false;
            btnWithdraw.Enabled = false;
            this.AcceptButton = btnFind;
            txtAccountNumber.Text = string.Empty;
            txtFistName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtBalance.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPINCode.Text = string.Empty;
            NumWithdrawAmount.Value = 0;
        }

        private void FrmWithraw_Load(object sender, EventArgs e)
        {
            _Reset();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show("Enter account number.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _Client = clsClients.Find(txtAccountNumber.Text);

            if (_Client != null)
            {
                gbClientCard.Enabled = true;
                btnWithdraw.Enabled = true;
                this.AcceptButton = btnWithdraw;
                txtFistName.Text = _Client.FirstName;
                txtLastName.Text = _Client.LastName;
                txtEmail.Text = _Client.Email;
                txtPhone.Text = _Client.Phone;
                txtBalance.Text = _Client.Balance.ToString();
                txtPINCode.Text = _Client.PinCode.ToString();
                btnClientID.Text = _Client.ID.ToString();
            }
            else
            {
                MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            return;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (NumWithdrawAmount.Value == 0)
            {
                MessageBox.Show("Please enter withdraw amount.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure?", "Message Box", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_Client.Withdraw(Convert.ToDecimal(NumWithdrawAmount.Value)))
                {
                    MessageBox.Show($"Amount withdrawn Successfuly. New Balance = {_Client.Balance}.", "Message Box", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong.Try again", "Message Box", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("withdrawal process canceled", "Message Box", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
            }
            _Reset();
        }
    }
}
