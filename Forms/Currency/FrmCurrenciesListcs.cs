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

namespace Bank_WindowsForm.Forms.Currency
{
    public partial class FrmCurrenciesListcs : Form
    {
        public FrmCurrenciesListcs()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FrmCurrenciesListcs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsCurrencies.GetAllCurrencies();
        }
    }
}
