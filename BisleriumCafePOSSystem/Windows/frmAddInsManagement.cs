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
    public partial class frmAddInsManagement : Form
    {
        private readonly AddIn addIn;
        private readonly AddInService addInService;

        int selectedAddInId;
        public frmAddInsManagement()
        {
            InitializeComponent();
            addIn = new AddIn();
            addInService = new AddInService();
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

        private void txtAddinPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }


        private void RefreshAddInDataGrid()
        {
            dgvAddinsData.Rows.Clear();

            var addIns = addInService.LoadAddIns();

            foreach (var addIn in addIns)
            {
                dgvAddinsData.Rows.Add(addIn.Id, addIn.Name, addIn.Price);
            }
        }

        private void ResetFields()
        {
            txtAddinName.Clear();
            txtAddinPrice.Clear();
        }
        //load proudct data into datagridview
        void BindGridView()
        {
            selectedAddInId = dgvAddinsData.Columns.Add("Id", "ID");
            dgvAddinsData.Columns[selectedAddInId].Visible = false;
            dgvAddinsData.Columns.Add("Name", "Coffee Name");
            dgvAddinsData.Columns.Add("Price", "Price");
            RefreshAddInDataGrid();

        }


        private void frmAddInsManagement_Load(object sender, EventArgs e)
        {
            BindGridView();
            dgvAddinsData.ClearSelection();
        }

        //Add addIn
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddinName.Text == string.Empty || txtAddinPrice.Text == string.Empty)
            {
                MessageBox.Show("Please fill both the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string addInName = txtAddinName.Text.Trim();

                    // Check if the add-in with the same name already exists
                    if (addInService.addIns.Any(a => a.Name.Equals(addInName, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("An add-in with this name already exists. Please use a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    AddIn newAddIn = new AddIn
                    {
                        Name = txtAddinName.Text.Trim(),
                        Price = decimal.Parse(txtAddinPrice.Text.Trim())
                        
                    };
                    addInService.AddAddIn(newAddIn);
                    MessageBox.Show("Add-in added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAddInDataGrid();
                    ResetFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAddinsData_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvAddinsData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAddinsData.SelectedRows[0];


                selectedAddInId = Convert.ToInt32(selectedRow.Cells[0].Value);
                txtAddinName.Text = selectedRow.Cells[1].Value.ToString();
                txtAddinPrice.Text = selectedRow.Cells[2].Value.ToString();

            }
            else
            {
                txtAddinName.Text = "";
                txtAddinPrice.Text = "";
            }
        }


        //Update Add-in
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddinName.Text == string.Empty || txtAddinPrice.Text == string.Empty)
            {
                MessageBox.Show("Please first select a row which you want to be updated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //addIn.Name = txtAddinName.Text.Trim();
              
                addIn.Price = Convert.ToDecimal(txtAddinPrice.Text.Trim());

                decimal newPrice;
                if (!decimal.TryParse(txtAddinPrice.Text.Trim(), out newPrice))
                {
                    MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Prompt for Admin Password
                string adminPassword = PromptForPassword();
                if (adminPassword == null)
                {
                    MessageBox.Show("Update Cancelled","Cancel", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                // Verify Password 
                if (!IsAdminPasswordCorrect(adminPassword))
                {
                    MessageBox.Show("Incorrect Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                UpdateAddInPrice(selectedAddInId, newPrice);
                MessageBox.Show("Price updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string adminPassword = Properties.Settings.Default.addinPricePass;
            return inputPassword == adminPassword;
        }

        public void UpdateAddInPrice(int addInId, decimal newPrice)
        {
            var addInToUpdate = addInService.addIns.FirstOrDefault(c => c.Id == addInId);
            if (addInToUpdate != null)
            {
                addInToUpdate.Price = newPrice;
                addInService.SaveAddIn();
                RefreshAddInDataGrid();
            }
            else
            {
                MessageBox.Show("Add-in not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //delete add-in
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAddinsData.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    selectedAddInId = Convert.ToInt32(dgvAddinsData.SelectedRows[0].Cells["Id"].Value);
                    DeleteAddIn(selectedAddInId);
                    RefreshAddInDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAddIn(int id)
        {
            var addInToDelete = addInService.addIns.FirstOrDefault(c => c.Id == id);
            if (addInToDelete != null)
            {
                addInService.addIns.Remove(addInToDelete);
                addInService.SaveAddIn();
                ResetFields();
            }
            else
            {
                MessageBox.Show("Add-in not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
