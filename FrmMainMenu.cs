using Bank_WindowsForm.Forms.Transactions;
using Bank_WindowsForm.Forms.User;
using System;
using System.Windows.Forms;
using BankBuisnessLayer;
using Bank_WindowsForm.Forms.Currency;

namespace Bank_WindowsForm
{
    public partial class FrmMainMenu : Form
    {
        bool isSideBarExpand = true;
        bool isManageClientsExpand = false;
        bool isTransactionsExpand = false;
        bool isManageUsersExpand = false;
        bool IsCurrenciesExpand = false;

        private void _ApplyAccessabilityRoles()
        {
            if (GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pAll))
                return; 


            if (!GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pAddUser))
                btnAddUser.Enabled = false;


            if (!GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pFindUser))
                btnFindUser.Enabled = false;


            if (!GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pUpdateUser))
                btnUpdateUser.Enabled = false;


            if (!GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pDeleteClient))
                btnDeleteClient.Enabled = false;


            if (!GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pDeleteUser))
                btnDeleteUser.Enabled = false;

            if (!GlobalSettings.CurrentUser.isAccessAllowed(clsUsers.enPermissions.pUsersList))
                btnUsersList.Enabled = false;


        }

        public FrmMainMenu()
        {
            InitializeComponent();
            _ApplyAccessabilityRoles();
        }
      
        private void DeExpandAll()
        {
            if (isManageClientsExpand)
                ManageClientTimer.Start();
            if(isTransactionsExpand)
                TransactionsTimer.Start();
            if(isManageUsersExpand)
                ManageUsersTimer.Start();
            if(IsCurrenciesExpand)
                CurrenciesTimer.Start();
        }

        //Clients
        private void btnManageClient_Click(object sender, EventArgs e)
        {
            DeExpandAll();
            ManageClientTimer.Start();
        }

        private void btnClientsList_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Clients List";
            pnlMainScreen.Controls.Clear();
            FrmClientsList Form = new FrmClientsList();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnFindClient_Click_1(object sender, EventArgs e)
        {
            lblHeader.Text = "Find Client";
            pnlMainScreen.Controls.Clear();
            FrmFindClient Form = new FrmFindClient();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Add Client";
            pnlMainScreen.Controls.Clear();
            FrmAddClient Form = new FrmAddClient();
            Form.TopLevel=false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            pnlManageClients.Height = pnlManageClients.MinimumSize.Height;
            lblUsername.Text = "Welcome " + GlobalSettings.CurrentUser.username +
                " [" + GlobalSettings.CurrentUser.FirstName + "].";
        }
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Update Client"; 
            pnlMainScreen.Controls.Clear();
            FrmUpdateClient Form = new FrmUpdateClient();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();

        }
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Delete Client";
            pnlMainScreen.Controls.Clear();
            FrmDeleteClientcs Form = new FrmDeleteClientcs();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            lblHeader.Text = "HOME";
            if (isSideBarExpand)
            {
                pnlSideBar.Width = pnlSideBar.MinimumSize.Width;
                isSideBarExpand = false;
            }
            else
            {
                pnlSideBar.Width = pnlSideBar.MaximumSize.Width;
                isSideBarExpand = true;
            }
        }

        //transactions
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            DeExpandAll();
            TransactionsTimer.Start();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            pnlMainScreen.Controls.Clear();
            lblHeader.Text = "Deposite Screen";
            FrmDeposite Form = new FrmDeposite();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            pnlMainScreen.Controls.Clear();
            lblHeader.Text = "Withdraw Screen";
            FrmWithraw Form = new FrmWithraw();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Transfer screen";
            pnlMainScreen.Controls.Clear();
            FrmTransfer Form = new FrmTransfer();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        //timers

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            DeExpandAll();
            ManageUsersTimer.Start();
        }

        private void ManageClientTimer_Tick(object sender, EventArgs e)
        {
            lblHeader.Text = "Manage Clients";
            pnlMainScreen.Controls.Clear();

            if (isManageClientsExpand)
            {
                pnlManageClients.Height = pnlManageClients.MinimumSize.Height;
                isManageClientsExpand = false;
                ManageClientTimer.Stop();

            }
            else
            {
                pnlManageClients.Height = pnlManageClients.MaximumSize.Height;
                isManageClientsExpand = true;
                ManageClientTimer.Stop();
            }
        }

        private void TransactionsTimer_Tick(object sender, EventArgs e)
        {
            lblHeader.Text = "Transactions";
            pnlMainScreen.Controls.Clear();

            if (isTransactionsExpand)
            {
                pnlTransactions.Height = pnlTransactions.MinimumSize.Height;
                isTransactionsExpand = false;
                TransactionsTimer.Stop();
            }
            else
            {
                pnlTransactions.Height = pnlTransactions.MaximumSize.Height;
                isTransactionsExpand = true;
                TransactionsTimer.Stop();
            }
        }

        private void ManageUsersTimer_Tick(object sender, EventArgs e)
        {
            lblHeader.Text = "Manage Users";
            pnlMainScreen.Controls.Clear();

            if (isManageUsersExpand)
            {
                pnlManageUser.Height = pnlManageUser.MinimumSize.Height;
                isManageUsersExpand = false;
                ManageUsersTimer.Stop();

            }
            else
            {
                pnlManageUser.Height = pnlManageUser.MaximumSize.Height;
                isManageUsersExpand = true;
                ManageUsersTimer.Stop();
            }
        }

        private void CurrenciesTimer_Tick(object sender, EventArgs e)
        {
            lblHeader.Text = "Currencies Screen";
            pnlMainScreen.Controls.Clear();

            if (IsCurrenciesExpand)
            {
                pnlCurrencies.Height = pnlCurrencies.MinimumSize.Height;
                IsCurrenciesExpand = false;
                CurrenciesTimer.Stop();
            }
            else
            {
                pnlCurrencies.Height = pnlCurrencies.MaximumSize.Height;
                IsCurrenciesExpand = true;
                CurrenciesTimer.Stop();
            }
        }


        //users
        private void btnUsersList_Click(object sender, EventArgs e)
        {

            lblHeader.Text = "Users List";
            pnlMainScreen.Controls.Clear();
            FrmUsersList Form = new FrmUsersList();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Find User";
            pnlMainScreen.Controls.Clear();
            FrmFindUser Form = new FrmFindUser();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Add User";
            pnlMainScreen.Controls.Clear();
            FrmAddUser Form = new FrmAddUser();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Update User";
            pnlMainScreen.Controls.Clear();
            FrmUpdateUser Form = new FrmUpdateUser();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Delete User";
            pnlMainScreen.Controls.Clear();
            FrmDeleteUser Form = new FrmDeleteUser();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            DeExpandAll();
            CurrenciesTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Currencies List";
            pnlMainScreen.Controls.Clear();
            FrmCurrenciesListcs Form = new FrmCurrenciesListcs();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnFindCuurency_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Find Currency";
            pnlMainScreen.Controls.Clear();
            FrmFindCurrency Form = new FrmFindCurrency();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "Update Rate";
            pnlMainScreen.Controls.Clear();
            FrmUpdateRate Form = new FrmUpdateRate();
            Form.TopLevel = false;
            Form.Dock = DockStyle.Fill;
            pnlMainScreen.Controls.Add(Form);
            Form.Show();
        }

    }
}