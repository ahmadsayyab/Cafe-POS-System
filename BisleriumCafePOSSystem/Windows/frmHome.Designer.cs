namespace BisleriumCafePOSSystem.Windows
{
    partial class frmHome
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
            this.btnManagCoffeeTypes = new System.Windows.Forms.Button();
            this.picCoffeeTypes = new System.Windows.Forms.PictureBox();
            this.pnlMainheading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffeeTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainheading
            // 
            this.pnlMainheading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainheading.Controls.Add(this.lblMainHeading);
            this.pnlMainheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainheading.Location = new System.Drawing.Point(0, 0);
            this.pnlMainheading.Name = "pnlMainheading";
            this.pnlMainheading.Size = new System.Drawing.Size(605, 70);
            this.pnlMainheading.TabIndex = 2;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(229, 24);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(72, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Home";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 435);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(605, 15);
            this.pnltaskBar.TabIndex = 3;
            // 
            // btnManagCoffeeTypes
            // 
            this.btnManagCoffeeTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagCoffeeTypes.Location = new System.Drawing.Point(28, 219);
            this.btnManagCoffeeTypes.Name = "btnManagCoffeeTypes";
            this.btnManagCoffeeTypes.Size = new System.Drawing.Size(192, 26);
            this.btnManagCoffeeTypes.TabIndex = 4;
            this.btnManagCoffeeTypes.Text = "Manage Coffee Types";
            this.btnManagCoffeeTypes.UseVisualStyleBackColor = true;
            this.btnManagCoffeeTypes.Click += new System.EventHandler(this.btnManagCoffeeTypes_Click);
            // 
            // picCoffeeTypes
            // 
            this.picCoffeeTypes.Image = global::BisleriumCafePOSSystem.Properties.Resources.coffee;
            this.picCoffeeTypes.Location = new System.Drawing.Point(70, 124);
            this.picCoffeeTypes.Name = "picCoffeeTypes";
            this.picCoffeeTypes.Size = new System.Drawing.Size(105, 89);
            this.picCoffeeTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoffeeTypes.TabIndex = 5;
            this.picCoffeeTypes.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.picCoffeeTypes);
            this.Controls.Add(this.btnManagCoffeeTypes);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Window";
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffeeTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.Button btnManagCoffeeTypes;
        private System.Windows.Forms.PictureBox picCoffeeTypes;
    }
}