using BisleriumCafePOSSystem.Core.Model;
using BisleriumCafePOSSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmMemberManagement : Form
    {
        private readonly MemberService memberService;
        private readonly Member member;

        int selectedMemberId;
        public frmMemberManagement()
        {
            InitializeComponent();
            memberService = new MemberService();
            member = new Member();
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

        private void txtMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidStringInput(e);
        }

        private void txtMemberContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnsureValidNumericInput(e);
        }

        //reset textboxes
        private void ResetControls()
        {
            txtMemberName.Clear();
            txtMemberContact.Clear();
            dtpJoiningDate.Value = DateTime.Now;
            cmbMembershipTypes.SelectedItem = null;
        

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMemberName.Text == string.Empty || txtMemberContact.Text == string.Empty
                || cmbMembershipTypes.SelectedItem == null )
            {
                MessageBox.Show("Please ensure all fields are filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    string phoneNumber = txtMemberContact.Text.Trim();

                    // Check if the add-in with the same name already exists
                    if (memberService.members.Any(a => a.PhoneNumber.Equals(phoneNumber, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show("Member with this Contact already exists. Please use a different contact.", "Duplicate Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Member newMember = new Member
                    {
                        Name = txtMemberName.Text.Trim(),
                        PhoneNumber = txtMemberContact.Text.Trim(),
                        
                        JoininDate = dtpJoiningDate.Value.ToString("yyyy-MM-dd"),
                        MembershipType = cmbMembershipTypes.SelectedItem.ToString()
                    };
                   


                    memberService.AddMember(newMember);

                    MessageBox.Show("Member added successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid();
                    ResetControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            
        }

        private void RefreshDataGrid()
        {

            dgvMembers.Rows.Clear();
            var members = memberService.LoadMembers();

            foreach (var member in members)
            {
                dgvMembers.Rows.Add(member.Id, member.Name, member.PhoneNumber, member.JoininDate,member.MembershipType);
            }
            dgvMembers.ClearSelection();
        }

        //load proudct data into datagridview
        void BindGridView()
        {
            selectedMemberId = dgvMembers.Columns.Add("Id", "ID");
            
            dgvMembers.Columns[selectedMemberId].Visible = false;

            dgvMembers.Columns.Add("Name", "Member Name");
            dgvMembers.Columns.Add("Contact", "Contact");
            dgvMembers.Columns.Add("Date", "Joining Date");
            dgvMembers.Columns.Add("Type", "Membership Type");
            RefreshDataGrid();

        }
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

            BindGridView();
            dgvMembers.ClearSelection();
        }

        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMembers.SelectedRows[0];



                selectedMemberId = Convert.ToInt32(selectedRow.Cells[0].Value);
                txtMemberName.Text = selectedRow.Cells[1].Value.ToString();
                txtMemberContact.Text = selectedRow.Cells[2].Value.ToString();
          
                if (DateTime.TryParse(selectedRow.Cells[3].Value?.ToString(), out DateTime dateValue))
                {
                    if (dateValue >= dtpJoiningDate.MinDate && dateValue <= dtpJoiningDate.MaxDate)
                    {
                        dtpJoiningDate.Value = dateValue;
                    }
                }
                cmbMembershipTypes.SelectedItem = selectedRow.Cells["Type"].Value.ToString();


            }
            else
            {
                txtMemberName.Text = "";
                txtMemberContact.Text = "";
                dtpJoiningDate.Value = DateTime.Now;
                cmbMembershipTypes.SelectedItem = null;
            }
        }



        //update member
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemberName.Text == string.Empty || txtMemberContact.Text == string.Empty
                || cmbMembershipTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select a row to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var memberToUpdate = memberService.members.FirstOrDefault(m => m.Id == selectedMemberId);
                if (memberToUpdate != null)
                {
                    memberToUpdate.Name = txtMemberName.Text.Trim();
                    memberToUpdate.PhoneNumber = txtMemberContact.Text.Trim();
                    memberToUpdate.JoininDate = dtpJoiningDate.Value.ToString("yyyy-MM-dd");
                    memberToUpdate.MembershipType = cmbMembershipTypes.SelectedItem.ToString();

                    memberService.SaveMembers();  
                    MessageBox.Show("Member data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetControls();
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //delete member
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMembers.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this member?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    selectedMemberId = Convert.ToInt32(dgvMembers.SelectedRows[0].Cells["Id"].Value);
                    DeleteMember(selectedMemberId);
                    RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMember(int id)
        {
            
            var memberToDelete = memberService.members.FirstOrDefault(c => c.Id == id);
            if (memberToDelete != null)
            {
                memberService.members.Remove(memberToDelete);
                memberService.SaveMembers();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Add-in not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
