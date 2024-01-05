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
    public partial class FrmClientsList : Form
    {
        public FrmClientsList()
        {
            InitializeComponent();
        }

        private void dataGridView34_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmClientsList_Load(object sender, EventArgs e)
        {
            dgvClientList.DataSource = clsClients.ClientsList();
        }
    }
}
