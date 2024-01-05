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

namespace Bank_WindowsForm.Forms.User
{
    public partial class FrmFindUser : Form
    {
        clsUsers _User; 
        public FrmFindUser()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter username.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _User = clsUsers.Find(txtUsername.Text);

            if (_User != null)
            {

                gbClientCard.Enabled = true;
                txtFistName.Text = _User.FirstName;
                txtLastName.Text = _User.LastName;
                txtEmail.Text = _User.Email;
                txtPhone.Text = _User.Phone;
                txtPassword.Text = _User.password.ToString();
                txtPermissions.Text = _User.permissions.ToString();
                btnUserID.Text = _User.ID.ToString();
                return;
            }

            MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFindUser_Load(object sender, EventArgs e)
        {
            gbClientCard.Enabled = false;
        }
    }
}
