using BisleriumCafePOSSystem.Core.Model;
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
        private readonly SaleService saleService;
        public frmSales()
        {
            InitializeComponent();
            addInService = new AddInService();
            coffeeService = new CoffeeService();
            saleService = new SaleService(new MemberService(), addInService, coffeeService);
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
            BindGridView();
           
        }

        private void btnBackToHomePage_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void btnAddToSale_Click(object sender, EventArgs e)
        {
            if (cmbCoffeeTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a coffee type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter the customer's name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCustomerPhoneNumber.Text))
            {
                MessageBox.Show("Please enter the customer's phone number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nudCoffeeQuantity.Value == 0)
            {
                MessageBox.Show("Please specify the coffee quantity.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!GetSelectedAddIns().Any())
            {
                MessageBox.Show("Please select at least one add-in.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Sale sale = new Sale
                {
                    CoffeeType = cmbCoffeeTypes.SelectedItem?.ToString(),
                    Name = txtCustomerName.Text.Trim(),
                    PhoneNumber = txtCustomerPhoneNumber.Text.Trim(),
                    Quantity = Convert.ToInt32(nudCoffeeQuantity.Value),
                    Date = dtpOrderDate.Value,
                    AddIns = GetSelectedAddIns(),
                };

                saleService.ProcessSale(sale);

                
                saleService.AddSale(sale);
                MessageBox.Show("Sale added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ResetFields();

                txtTotalBill.Text = sale.TotalBill.ToString();
                txtDiscount.Text = sale.Discount.ToString();
                UpdateDataGridView(sale);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private List<string> GetSelectedAddIns()
        {
            var selectedAddIns = new List<string>();

            
            foreach (var item in cklCoffeeAddIns.CheckedItems)
            {
                selectedAddIns.Add(item.ToString());
            }

            return selectedAddIns;
        }


        void BindGridView()
        {

            dgvSales.Columns.Add("Name", "Customer Name");
            dgvSales.Columns.Add("Type", "Coffee Type");
            dgvSales.Columns.Add("Quantity", "Quantity");
            dgvSales.Columns.Add("Bill", "Total Bill");
            dgvSales.Columns.Add("Discount", "Discount");
            dgvSales.Columns.Add("Date", "Order Date");
            

        }

        private void UpdateDataGridView(Sale sale)
        {
            dgvSales.Rows.Add(
                sale.Name,
                sale.CoffeeType,
                sale.Quantity,
                sale.TotalBill.ToString("C"),
                sale.Discount.ToString("C"),
                sale.Date
            );
        }

        private void ResetFields()
        {
            cmbCoffeeTypes.SelectedItem = null;
            txtCustomerName.Clear();
            txtCustomerPhoneNumber.Clear();
            nudCoffeeQuantity.Value = 0;
            dtpOrderDate.Value = DateTime.Now;
           
        }


        //Extract Data from datagridview

        private List<Sale> ExtractSalesDetailsFromGrid()
        {
            var details = new List<Sale>();

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row at the bottom

                var detail = new Sale();

                detail.Name = row.Cells["Name"].Value?.ToString();
                detail.CoffeeType = row.Cells["Type"].Value?.ToString();

                if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity))
                {
                    detail.Quantity = quantity;
                }

                if (double.TryParse(row.Cells["Bill"].Value?.ToString(), out double totalBill))
                {
                    detail.TotalBill = totalBill;
                }

                if (double.TryParse(row.Cells["Discount"].Value?.ToString(), out double discount))
                {
                    detail.Discount = discount;
                }

                if (DateTime.TryParse(row.Cells["Date"].Value?.ToString(), out DateTime date))
                {
                    detail.Date = date;
                }

                details.Add(detail);
            }

            return details;
        }


        private void btnProceedSale_Click(object sender, EventArgs e)
        {
            var salesDetails = ExtractSalesDetailsFromGrid();
            var grandTotal =Convert.ToDecimal(txtTotalBill.Text);
            var discount = Convert.ToDecimal(txtDiscount.Text);
            
            frmCheckOut checkOut = new frmCheckOut(salesDetails, grandTotal, discount);
            this.Hide();
            checkOut.ShowDialog();
            this.Close();
        }
    }
}
