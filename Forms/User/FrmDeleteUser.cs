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
    public partial class FrmDeleteUser : Form
    {
        clsUsers _User;
        public FrmDeleteUser()
        {
            InitializeComponent();
        }

        private void _Reset()
        {
            gbClientCard.Enabled = false;
            btnDelete.Enabled = false;
            this.AcceptButton = btnFind;
            txtUsername.Text = string.Empty;
            txtFistName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtPermissions.Text = string.Empty;
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
                btnDelete.Enabled = true;
                this.AcceptButton = btnDelete;
                txtFistName.Text = _User.FirstName;
                txtLastName.Text = _User.LastName;
                txtEmail.Text = _User.Email;
                txtPhone.Text = _User.Phone;
                txtPass.Text = _User.password;
                txtPermissions.Text = _User.permissions.ToString();
                btnClientID.Text = _User.ID.ToString();
                return;
            }

            MessageBox.Show("User NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsClients.Delete(_User.ID))
                {
                    MessageBox.Show("User deleted successfully.", "Message Box",
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

        private void FrmDeleteUser_Load(object sender, EventArgs e)
        {
            _Reset();
        }
    }
}
