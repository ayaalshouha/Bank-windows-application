using BankBuisnessLayer;
using System;
using System.Windows.Forms;

namespace Bank_WindowsForm
{
    public partial class FrmFindClient : Form
    {
        public FrmFindClient()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAccountNumber.Text)) { 
                MessageBox.Show("Enter account number.", "Message Box",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; 
            }

            clsClients Client = clsClients.Find(txtAccountNumber.Text);

            if(Client != null)
            {

                gbClientCard.Enabled = true;
                txtFistName.Text = Client.FirstName; 
                txtLastName.Text = Client.LastName;
                 txtEmail.Text = Client.Email;
                txtPhone.Text = Client.Phone;
                txtBalance.Text = Client.Balance.ToString();
                txtPINCode.Text = Client.PinCode.ToString();
                btnClientID.Text = Client.ID.ToString();
                return; 
            }

            MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void FrmFindClient_Load(object sender, EventArgs e)
        {
            gbClientCard.Enabled = false;
        }
    }
}
