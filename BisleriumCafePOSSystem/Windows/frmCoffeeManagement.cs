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
using System.Xml.Linq;

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmCoffeeManagement : Form
    {
        private readonly CoffeeService coffeeService;
        private readonly Coffee coffee;
        
        int selectedCoffeeId;
        public frmCoffeeManagement()
        {
            InitializeComponent();
            coffeeService = new CoffeeService();
            coffee = new Coffee();
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
            else if (ch == 46)
            {
                // Allow period/dot (ASCII code 46)
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void txtCoffeePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        private void RefreshCoffeeDataGrid()
        {
  
            dgvCoffeeTypeData.Rows.Clear();

            var coffees = coffeeService.LoadCoffees();

            foreach (var coffee in coffees)
            {
                dgvCoffeeTypeData.Rows.Add(coffee.Id,coffee.Name, coffee.Price);
            }

            dgvCoffeeTypeData.ClearSelection();
        }

        //add coffee type
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCoffeePrice.Text == string.Empty || txtCoffeePrice.Text == string.Empty)
            {
                MessageBox.Show("Please fill both the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string coffeeType = txtCoffeeType.Text.Trim();

                    // Check if the add-in with the same name already exists
                    if (coffeeService.coffees.Any(a => a.Name.Equals(coffeeType, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("Coffee type with this name already exists. Please use a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Coffee newCoffee = new Coffee
                    {
                        Name = txtCoffeeType.Text.Trim(),
                        Price = double.Parse(txtCoffeePrice.Text.Trim())
                    };

                    coffeeService.AddCoffee(newCoffee);
                    MessageBox.Show("Coffee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshCoffeeDataGrid();
                    ResetFields();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetFields()
        {
            txtCoffeeType.Clear();
            txtCoffeePrice.Clear();
            
        }
        //load proudct data into datagridview
        void BindGridView()
        {
            selectedCoffeeId = dgvCoffeeTypeData.Columns.Add("Id", "ID");
            dgvCoffeeTypeData.Columns[selectedCoffeeId].Visible = false;
            dgvCoffeeTypeData.Columns.Add("Name", "Coffee Name");
            dgvCoffeeTypeData.Columns.Add("Price", "Price");
            RefreshCoffeeDataGrid();
            
        }
        private void frmCoffeeManagement_Load(object sender, EventArgs e)
        {
            BindGridView();
            dgvCoffeeTypeData.ClearSelection();
        }

        
        private void dgvCoffeeTypeData_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dgvCoffeeTypeData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCoffeeTypeData.SelectedRows[0];


                selectedCoffeeId = Convert.ToInt32(selectedRow.Cells[0].Value);
                txtCoffeeType.Text = selectedRow.Cells[1].Value.ToString();
                txtCoffeePrice.Text = selectedRow.Cells[2].Value.ToString();

            }
            else
            {
                txtCoffeeType.Text = "";
                txtCoffeePrice.Text = "";
            }


        }
        //update coffee data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCoffeeType.Text == string.Empty || txtCoffeePrice.Text == string.Empty)
            {
                MessageBox.Show("Please first select a row which you want to be updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //coffee.Name = txtCoffeeType.Text.Trim();
                coffee.Price =Convert.ToDouble(txtCoffeePrice.Text.Trim());
               

                double newPrice;
                if (!double.TryParse(txtCoffeePrice.Text.Trim(), out newPrice))
                {
                    MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Prompt for Admin Password
                string adminPassword = PromptForPassword();
                if (adminPassword == null)
                {
                    MessageBox.Show("Update Cancelled.");
                    return;
                }

                // Verify Password 
                if (!IsAdminPasswordCorrect(adminPassword))
                {
                    MessageBox.Show("Incorrect Password" , "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                UpdateCoffeePrice(selectedCoffeeId, newPrice); 
                MessageBox.Show("Price updated successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFields();
            }
           

        }


        //propmt for password
        private string PromptForPassword()
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter Admin Password",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Password:" };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "OK", Left = 20, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }


        //match the password
        private bool IsAdminPasswordCorrect(string inputPassword)
        {
            string adminPassword = Properties.Settings.Default.coffeePricePass; 
            return inputPassword == adminPassword;
        }

        public void UpdateCoffeePrice(int coffeeId, double newPrice)
        {
            var coffeeToUpdate = coffeeService.coffees.FirstOrDefault(c => c.Id == coffeeId);
            if (coffeeToUpdate != null)
            {
                coffeeToUpdate.Price = newPrice;
                coffeeService.SaveCoffees();
                RefreshCoffeeDataGrid();
            }
            else
            {
                MessageBox.Show("Coffee not found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //delete coffee 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCoffeeTypeData.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    selectedCoffeeId = Convert.ToInt32(dgvCoffeeTypeData.SelectedRows[0].Cells["Id"].Value);
                    DeleteCoffee(selectedCoffeeId);
                    RefreshCoffeeDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCoffee(int id)
        {
            var coffeeToDelete = coffeeService.coffees.FirstOrDefault(c => c.Id == id);
            if (coffeeToDelete != null)
            {
                coffeeService.coffees.Remove(coffeeToDelete);
                coffeeService.SaveCoffees();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Coffee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToHomeScreen_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}
