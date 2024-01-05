using BankBuisnessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_WindowsForm
{
    public partial class FrmLogin : Form
    {
        byte trials = 3;
        bool loginFailed = (GlobalSettings.CurrentUser == null);
        string UsernamePlaceHolderText = "Username...";
        string PasswordPlaceHolderText = "Password...";

        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = string.Empty; 
            txtPassword.Text = PasswordPlaceHolderText;
            txtUsername.Text = UsernamePlaceHolderText;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
        }

        private void _Refresh()
        {
            txtUsername.Focus();
            txtPassword.Text = PasswordPlaceHolderText;
            txtUsername.Text = UsernamePlaceHolderText;
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            trials = 3;
            label3.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GlobalSettings.CurrentUser = clsUsers.Authintication(txtUsername.Text, txtPassword.Text);
            loginFailed = (GlobalSettings.CurrentUser == null);

            if (loginFailed)
            {
                trials--;
                label3.Text = $"Invalid Username\\Password.\nYou Have {trials} Trial(s) Left!";
            }

            if (trials == 0)
            {
                MessageBox.Show("You have tried 3 times. Times sessoin out!", "Message Box",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }

            if (GlobalSettings.CurrentUser != null)
            {
                if (clsRecords.SaveLoginRecord(GlobalSettings.CurrentUser.ID))
                {
                    
                    FrmMainMenu MainMenuForm = new FrmMainMenu();
                    MainMenuForm.ShowDialog();
                    _Refresh();
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == UsernamePlaceHolderText)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Username is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == PasswordPlaceHolderText)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password is required!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = UsernamePlaceHolderText;
                txtUsername.ForeColor = Color.Gray;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = PasswordPlaceHolderText;
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
