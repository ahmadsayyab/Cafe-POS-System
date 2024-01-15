namespace BisleriumCafePOSSystem.Windows
{
    partial class frmCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainheading = new System.Windows.Forms.Panel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.pnltaskBar = new System.Windows.Forms.Panel();
            this.rtxReceipt = new System.Windows.Forms.RichTextBox();
            this.btnDownloadReceipt = new System.Windows.Forms.Button();
            this.btnBackToOrderPage = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlMainheading.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainheading
            // 
            this.pnlMainheading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainheading.Controls.Add(this.lblMainHeading);
            this.pnlMainheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainheading.Location = new System.Drawing.Point(0, 0);
            this.pnlMainheading.Name = "pnlMainheading";
            this.pnlMainheading.Size = new System.Drawing.Size(667, 70);
            this.pnlMainheading.TabIndex = 5;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(235, 27);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(118, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Checkout ";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 435);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(667, 15);
            this.pnltaskBar.TabIndex = 6;
            // 
            // rtxReceipt
            // 
            this.rtxReceipt.Location = new System.Drawing.Point(31, 85);
            this.rtxReceipt.Name = "rtxReceipt";
            this.rtxReceipt.Size = new System.Drawing.Size(592, 252);
            this.rtxReceipt.TabIndex = 7;
            this.rtxReceipt.Text = "";
            // 
            // btnDownloadReceipt
            // 
            this.btnDownloadReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadReceipt.Location = new System.Drawing.Point(224, 360);
            this.btnDownloadReceipt.Name = "btnDownloadReceipt";
            this.btnDownloadReceipt.Size = new System.Drawing.Size(163, 28);
            this.btnDownloadReceipt.TabIndex = 0;
            this.btnDownloadReceipt.Text = "Download Receipt";
            this.btnDownloadReceipt.UseVisualStyleBackColor = true;
            this.btnDownloadReceipt.Click += new System.EventHandler(this.btnDownloadReceipt_Click);
            // 
            // btnBackToOrderPage
            // 
            this.btnBackToOrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToOrderPage.Location = new System.Drawing.Point(405, 360);
            this.btnBackToOrderPage.Name = "btnBackToOrderPage";
            this.btnBackToOrderPage.Size = new System.Drawing.Size(180, 28);
            this.btnBackToOrderPage.TabIndex = 8;
            this.btnBackToOrderPage.Text = "Back to Order Page";
            this.btnBackToOrderPage.UseVisualStyleBackColor = true;
            this.btnBackToOrderPage.Click += new System.EventHandler(this.btnBackToOrderPage_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(44, 360);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(163, 28);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // frmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnBackToOrderPage);
            this.Controls.Add(this.btnDownloadReceipt);
            this.Controls.Add(this.rtxReceipt);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOut Window";
            this.Load += new System.EventHandler(this.frmCheckOut_Load);
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.RichTextBox rtxReceipt;
        private System.Windows.Forms.Button btnDownloadReceipt;
        private System.Windows.Forms.Button btnBackToOrderPage;
        private System.Windows.Forms.Button btnPayment;
    }
}