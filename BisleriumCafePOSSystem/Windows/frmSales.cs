using BisleriumCafePOSSystem.Core.Services;
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
    public partial class frmSales : Form
    {
        private readonly AddInService addInService;
        private readonly CoffeeService coffeeService;
        public frmSales()
        {
            InitializeComponent();
            addInService = new AddInService();
            coffeeService = new CoffeeService();
        }

        //Ensure valid string inputs
        private void EnsureValidStringInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 32)
            {
                // Allow space (ASCII code 32)
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }


        //Ensure valid numeric inputs
        private void EnsureValidNumericInput(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                // Allow backspace (ASCII code 8)
                e.Handled = false;
            }
            else if (ch == 43)
            {
                // Allow plus sign (ASCII code 43)
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtCustomerPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }


        
        private void PopulateCheckedListBox()
        {

            var addIns = addInService.LoadAddIns();

            cklCoffeeAddIns.Items.Clear();
            foreach (var addIn in addIns)
            {
                cklCoffeeAddIns.Items.Add(addIn.Name);
            }
        }

        private void PopulateCombobox()
        {
            var coffees = coffeeService.LoadCoffees();

            foreach(var coffee in coffees)
            {
                cmbCoffeeTypes.Items.Add(coffee.Name);
            }
        }
        private void frmSales_Load(object sender, EventArgs e)
        {
            PopulateCheckedListBox();
            PopulateCombobox();
        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
