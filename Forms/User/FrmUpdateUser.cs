using BankBuisnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_WindowsForm.Forms.User
{
    public partial class FrmUpdateUser : Form
    {
        clsUsers _User;
        int _Permissions;
        public FrmUpdateUser()
        {
            InitializeComponent();
        }

        private int _ReadPermissions()
        {
            if (chbDeleteUser.Checked && chbDleteClient.Checked
                && chbFindUser.Checked && ChbAddUser.Checked
                && chbUpdateUser.Checked && chbUserList.Checked)
            {
                return -1;
            }

            if (chbDeleteUser.Checked)
                _Permissions += (int)clsUsers.enPermissions.pDeleteUser;

            if (chbDleteClient.Checked)
                _Permissions += (int)clsUsers.enPermissions.pDeleteClient;

            if (chbFindUser.Checked)
                _Permissions += (int)clsUsers.enPermissions.pFindUser;

            if (chbUserList.Checked)
                _Permissions += (int)clsUsers.enPermissions.pUsersList;

            if (chbUpdateUser.Checked)
                _Permissions += (int)clsUsers.enPermissions.pUpdateUser;

            if (ChbAddUser.Checked)
                _Permissions += (int)clsUsers.enPermissions.pAddUser;

            return _Permissions;
        }
        private bool _IsAllFilled()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text)
                    || string.IsNullOrWhiteSpace(txtFistName.Text)
                    || string.IsNullOrWhiteSpace(txtLastName.Text)
                    || string.IsNullOrWhiteSpace(txtPhone.Text)
                    || string.IsNullOrWhiteSpace(txtPassword.Text)
                    || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return false;
            }
            return true;
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
                gbPermissions.Enabled = true;
                gbClientCard.Enabled = true;
                btnUpdate.Enabled = true;
                this.AcceptButton = btnUpdate;
                txtUsername.Text = _User.username;
                txtFistName.Text = _User.FirstName;
                txtLastName.Text = _User.LastName;
                txtEmail.Text = _User.Email;
                txtPhone.Text = _User.Phone;
                txtPassword.Text = _User.password;
              
                return;
            }

            MessageBox.Show("Client NOT Found!", "Message Box", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnFind;
            gbClientCard.Enabled = false;
            gbPermissions.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_IsAllFilled())
            {
                _User.FirstName = txtFistName.Text;
                _User.LastName = txtLastName.Text;
                _User.username = txtUsername.Text;
                _User.Email = txtEmail.Text;
                _User.Phone = txtPhone.Text;
                _User.password = txtPassword.Text;
                _User.permissions = _ReadPermissions();

                if (_User.Save())
                {
                    MessageBox.Show("User updated successfully.", "Message Box",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbClientCard.Enabled = false;
                    btnUpdate.Enabled = false;
                    gbPermissions.Enabled=false;
                }
                else
                {
                    MessageBox.Show("Something went wrong! Try again.", "Message Box", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the information first.", "Message Box", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
