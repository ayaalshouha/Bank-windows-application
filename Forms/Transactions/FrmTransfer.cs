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
    public partial class FrmTransfer : Form
    {
        clsClients _Client1;
        clsClients _Client2;

        public FrmTransfer()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            gbToClient.Enabled = false;
            gbFromClient.Enabled = false;
            btnFind2.Enabled = false;
            numericUpDown1.Enabled = false;
            btnTransfer.Enabled = false;
            txtAccount2.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gbFromClient_Enter(object sender, EventArgs e)
        {

        }

        private void btnFind1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccount1.Text))
            {
                MessageBox.Show("Enter account number.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

             _Client1 = clsClients.Find(txtAccount1.Text);

            if (_Client1 != null)
            {

                gbFromClient.Enabled = true;
                btnFind2.Enabled = true;
                txtAccount2.Enabled=true;
                txtFirstName.Text = _Client1.FirstName;
                txtLastname.Text = _Client1.LastName;
                txtEmail.Text = _Client1.Email;
                txtPhone.Text = _Client1.Phone;
                txtAccountBalance.Text = _Client1.Balance.ToString();
                return;
            }

            MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
           
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccount2.Text))
            {
                MessageBox.Show("Enter account number.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _Client2 = clsClients.Find(txtAccount2.Text);

            if (_Client2 != null)
            {
                gbToClient.Enabled = true;
                numericUpDown1.Enabled = true;
                txtFirstName2.Text = _Client2.FirstName;
                txtLastName2.Text = _Client2.LastName;
                txtEmail2.Text = _Client2.Email;
                txtPhone2.Text = _Client2.Phone;
                txtAccount2.Text = _Client2.Balance.ToString();
                return;
            }

            MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

       
        private void FrmTransfer_Load(object sender, EventArgs e)
        {
            _Reset(); 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            btnTransfer.Enabled = true; 
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_Client1.Transfer(_Client2, numericUpDown1.Value))
                {
                    MessageBox.Show($"{numericUpDown1.Value} Transfered successfully from {_Client1.AccountNumber} To {_Client2.AccountNumber}.", "Message Box", MessageBoxButtons.OK,
                   MessageBoxIcon.Hand);
                }else
                {
                    MessageBox.Show("Something went wrong,Try again.", "MessageBox", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                   
            }else
            {
                MessageBox.Show("Transfer process canceled", "MessageBox", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            _Reset(); 
        }
            
    }
}
