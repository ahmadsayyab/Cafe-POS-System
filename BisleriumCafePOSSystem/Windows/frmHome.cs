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
    }
}
