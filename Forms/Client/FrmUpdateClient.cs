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
    public partial class FrmUpdateClient : Form
    {
        clsClients _Client; 
        public FrmUpdateClient()
        {
            InitializeComponent();
        }

        private bool _IsAllFilled()
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text)
                  || string.IsNullOrWhiteSpace(txtFistName.Text)
                  || string.IsNullOrWhiteSpace(txtLastName.Text)
                  || string.IsNullOrWhiteSpace(txtPhone.Text)
                  || string.IsNullOrWhiteSpace(txtPINCode.Text)
                  || string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_IsAllFilled())
            {
                _Client.FirstName = txtFistName.Text;
                _Client.LastName = txtLastName.Text;
                _Client.AccountNumber=txtAccountNumber.Text;
                _Client.Email = txtEmail.Text;
                _Client.Phone = txtPhone.Text;
                _Client.Balance = Convert.ToDecimal(txtBalance.Text);
                _Client.PinCode = Convert.ToInt32(txtPINCode.Text);

                if (_Client.Save())
                {
                    MessageBox.Show("Client saved successfully.", "Message Box",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //txtFistName.Text = _Client.FirstName;
                    //txtLastName.Text = _Client.LastName;
                    //txtEmail.Text = _Client.Email;
                    //txtPhone.Text = _Client.Phone;
                    //txtBalance.Text = _Client.Balance.ToString();
                    //txtPINCode.Text = _Client.PinCode.ToString();
                    //btnClientID.Text = _Client.ID.ToString();

                    gbClientCard.Enabled = false;
                    btnUpdate.Enabled = false;
                    return;
                }

                MessageBox.Show("Something went wrong! Try again.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Please fill all the information first.", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
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
                btnUpdate.Enabled = true;
                this.AcceptButton = btnUpdate;
                txtFistName.Text = _Client.FirstName;
                txtLastName.Text = _Client.LastName;
                txtEmail.Text = _Client.Email;
                txtPhone.Text = _Client.Phone;
                txtBalance.Text = _Client.Balance.ToString();
                txtPINCode.Text = _Client.PinCode.ToString();
                btnClientID.Text = _Client.ID.ToString();
                return;
            }

            MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        private void FrmUpdateClient_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnFind;
            gbClientCard.Enabled = false;
            btnUpdate.Enabled = false;
        }
    }
}
