using BisleriumCafePOSSystem.Core.Services;
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

namespace BisleriumCafePOSSystem.Windows
{
    public partial class frmGenerateReport : Form
    {
        private readonly SaleService saleService;
        MemberService memberService = new MemberService();
        AddInService addInService = new AddInService();
        CoffeeService coffeeService = new CoffeeService();


        public frmGenerateReport()
        {
            InitializeComponent();
            saleService = new SaleService(memberService, addInService, coffeeService);
           
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (rdoTopFiveSales.Checked)
            {

                lblTotalRevenue.Visible = false;
                var allSales = saleService.GetAllSales();
                var reportData = saleService.GenerateReportDataForSales(allSales);
                dgvReport.DataSource = null;

                dgvReport.DataSource = reportData;
                dgvReport.Refresh();
            }
            else if (rdoTopFiveDailyReport.Checked)
            {
                lblTotalRevenue.Visible = false;
                var selectedDate = dtpSelectDate.Value;
                var dailySales = saleService.GetSalesByDate(selectedDate);
                var reportData = saleService.GenerateReportDataForSales(dailySales);
                dgvReport.DataSource = null;

                dgvReport.DataSource = reportData;
                dgvReport.Refresh();
            }
            else if (rdoTopFiveMonthlyReport.Checked)
            {
                lblTotalRevenue.Visible = false;
                var month = dtpSelectDate.Value.Month;
                var year = dtpSelectDate.Value.Year;
                var monthlySales = saleService.GetSalesByMonth(month, year);
                var reportData = saleService.GenerateReportDataForSales(monthlySales);
                dgvReport.DataSource = null;

                dgvReport.DataSource = reportData;
                dgvReport.Refresh();
            }
            else 
            {


                var allSales = saleService.GetAllSales();
                dgvReport.DataSource = null;
                dgvReport.AutoGenerateColumns = true;
                
                dgvReport.DataSource = allSales;
                dgvReport.Columns["Id"].Visible = false;
                
                lblTotalRevenue.Text = $"Total Revenue: ${saleService.CalculateTotalRevenue(allSales)}";

                dgvReport.Refresh();

                
                
            }
        }


        private void ExportToPdf(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewColumn column in dgv.Columns)
            {

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD)));
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value?.ToString() ?? "", new iTextSharp.text.Font(bf, 8)));
                }
            }

            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void btnDownloadReport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "Report.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPdf(dgvReport, saveFileDialog.FileName);
                }
                MessageBox.Show("Report saved as PDF.", "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No data available to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
