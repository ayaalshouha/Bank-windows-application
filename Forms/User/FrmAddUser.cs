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
    public partial class FrmAddUser : Form
    {
        clsUsers _User;
        int _Permissions = 0;
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void _ClearAll()
        {
            ChbAddUser.Checked = false;
            chbDeleteUser.Checked = false;
            chbUpdateUser.Checked = false;
            chbUserList .Checked = false;
            chbFindUser.Checked = false;
            chbDleteClient.Checked = false;

            txtUsername.Text = string.Empty;
            txtFistName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
           
        }

        private void _ReadUserInfo()
        {
            _User.username = txtUsername.Text;
            _User.password = txtPassword.Text;
            _User.FirstName = txtFistName.Text;
            _User.LastName = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.Phone = txtPhone.Text;
            _User.permissions = _ReadPermissions();
        }

        private int _ReadPermissions()
        {
            if(chbDeleteUser.Checked && chbDleteClient.Checked 
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

            if(chbUserList.Checked)
                _Permissions += (int)clsUsers.enPermissions.pUsersList;

            if (chbUpdateUser.Checked)
                _Permissions += (int)clsUsers.enPermissions.pUpdateUser;

            if (ChbAddUser.Checked)
                _Permissions += (int)clsUsers.enPermissions.pAddUser;

            return _Permissions; 
        }
       
        private bool _IsAllFilles()
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

        private void FrmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_IsAllFilles())
            {
                if (!clsUsers.isExist(txtUsername.Text))
                {
                    _User = new clsUsers();
                    _ReadUserInfo();

                    if (_User.Save())
                    {
                        MessageBox.Show("User Saved Successfully.", "Message Box", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                        _ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong! Try again.", "Message Box", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username already used.Try another username.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    txtUsername.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please fill all informations.", "Message Box", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }
    }
}
