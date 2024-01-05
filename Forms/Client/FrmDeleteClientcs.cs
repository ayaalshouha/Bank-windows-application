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
    public partial class FrmDeleteClientcs : Form
    {
        private clsClients _Client;

        public FrmDeleteClientcs()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            gbClientCard.Enabled = false;
            btnDelete.Enabled = false;
            this.AcceptButton = btnFind;
            txtAccountNumber.Text = string.Empty;
            txtFistName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtBalance.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPINCode.Text = string.Empty;
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
                btnDelete.Enabled = true;
                this.AcceptButton = btnDelete;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this client?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsClients.Delete(_Client.ID))
                {
                    MessageBox.Show("Client deleted successfully.", "Message Box",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again.", "Message Box",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Deletion process canceled!", "Message Box",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _Reset();
        }

        

        private void FrmDeleteClientcs_Load(object sender, EventArgs e)
        {
            _Reset();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbClientCard_Enter(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
