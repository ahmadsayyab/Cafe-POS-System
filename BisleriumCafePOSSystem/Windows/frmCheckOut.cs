using BisleriumCafePOSSystem.Core.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmCheckOut : Form
    {
        private List<Sale> saleDetails;
        private decimal grandTotal;
        private decimal discount;
        public frmCheckOut(List<Sale> saleDetails, decimal grandTotal, decimal discount)
        {
            InitializeComponent();
            this.saleDetails = saleDetails;
            this.grandTotal = grandTotal;
            this.discount = discount;
        }


        //generate Receipt

        private void GenerateReceipt()
        {
            rtxReceipt.Clear();

            // Set the center alignment
            rtxReceipt.SelectionAlignment = HorizontalAlignment.Center;

            StringBuilder receiptContent = new StringBuilder();
            receiptContent.AppendLine("Receipt\n---------\nCoffee(s) Purchased:\n");

            foreach (var coffee in saleDetails)
            {
                receiptContent.AppendLine($"\nName: {coffee.Name}  \nCoffee Type: {coffee.CoffeeType} \nQuantity: {coffee.Quantity}");
            }


            receiptContent.AppendLine($"\nGrand Total: ${grandTotal} \nDiscount: {discount} %");
            rtxReceipt.Text = receiptContent.ToString();


        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            GenerateReceipt();
        }



        //download Receipt in pdf form
        private void SaveReceiptAsPdf()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF file (*.pdf)|*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                    pdfDoc.Open();
                    pdfDoc.Add(new Paragraph(rtxReceipt.Text));
                    pdfDoc.Close();
                    MessageBox.Show("Receipt saved as PDF.", "Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDownloadReceipt_Click(object sender, EventArgs e)
        {
            SaveReceiptAsPdf();
        }

        private void btnBackToOrderPage_Click(object sender, EventArgs e)
        {
            frmSales sales = new frmSales();
            this.Hide();
            sales.ShowDialog();
            this.Close();

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            this.Hide();
            payment.ShowDialog();
            this.Close();

        }
    }
}
