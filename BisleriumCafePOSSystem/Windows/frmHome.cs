using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnManagCoffeeTypes_Click(object sender, EventArgs e)
        {
            frmCoffeeManagement coffeeManagement = new frmCoffeeManagement();
            this.Hide();
            coffeeManagement.ShowDialog();
            this.Close();
        }

        private void btnAddInsManagement_Click(object sender, EventArgs e)
        {
            frmAddInsManagement addinsManagement = new frmAddInsManagement();
            this.Hide();
            addinsManagement.ShowDialog();
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            frmSales sale = new frmSales();
            this.Hide();
            sale.ShowDialog();
            this.Close();
        }
    }
}
