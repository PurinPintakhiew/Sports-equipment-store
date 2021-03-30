using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreanaSportZ
{
    public partial class Munu : Form
    {
        public Munu()
        {
            InitializeComponent();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            
            Sale f = new Sale();
            f.ShowDialog();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            Product f = new Product();
            f.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category f = new Category();
            f.ShowDialog();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            company f = new company();
            f.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerA f = new CustomerA();
            f.ShowDialog();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputProduct f = new InputProduct();
            f.ShowDialog();
        }
    }
}
