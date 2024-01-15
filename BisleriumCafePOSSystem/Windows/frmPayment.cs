using BisleriumCafePOSSystem.Core.Model;
using BisleriumCafePOSSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmPayment : Form
    {
        private readonly Payment payment;
        private readonly PaymentService paymentService;
        public frmPayment()
        {
            InitializeComponent();
            payment = new Payment();
            paymentService = new PaymentService();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
           
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == string.Empty)
            {
                MessageBox.Show("Please enter customer name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {

                    Payment payment = new Payment
                    {
                        Name = txtCustomerName.Text.Trim(),

                    };
  
                    paymentService.AddPayment(payment);
                    MessageBox.Show("Payment processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
