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
    public partial class FrmUsersList : Form
    {
        public FrmUsersList()
        {
            InitializeComponent();
        }

        private void FrmUsersList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsUsers.UsersList();

        }
    }
}
