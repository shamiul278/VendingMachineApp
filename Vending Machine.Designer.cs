using System;
using System.Windows.Forms;

namespace VendingMachineApp
{
    partial class VendingMachineapp : Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingMachineapp));
            this.btnWater = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.btnSoda = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.btnOnePound = new System.Windows.Forms.Button();
            this.btnFivePound = new System.Windows.Forms.Button();
            this.btnTenPound = new System.Windows.Forms.Button();
            this.btnTwentyPound = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWater
            // 
            this.btnWater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWater.BackgroundImage")));
            this.btnWater.Location = new System.Drawing.Point(155, 33);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(146, 172);
            this.btnWater.TabIndex = 0;
            this.btnWater.Text = "Mineral Water";
            this.btnWater.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnCoke
            // 
            this.btnCoke.Image = ((System.Drawing.Image)(resources.GetObject("btnCoke.Image")));
            this.btnCoke.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCoke.Location = new System.Drawing.Point(733, 33);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(146, 172);
            this.btnCoke.TabIndex = 1;
            this.btnCoke.Text = "Coke";
            this.btnCoke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoke.UseVisualStyleBackColor = true;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            // 
            // btnSoda
            // 
            this.btnSoda.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoda.Image = ((System.Drawing.Image)(resources.GetObject("btnSoda.Image")));
            this.btnSoda.Location = new System.Drawing.Point(155, 243);
            this.btnSoda.Name = "btnSoda";
            this.btnSoda.Size = new System.Drawing.Size(146, 178);
            this.btnSoda.TabIndex = 2;
            this.btnSoda.Text = "Soda";
            this.btnSoda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSoda.UseVisualStyleBackColor = true;
            this.btnSoda.Click += new System.EventHandler(this.btnSoda_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.Image = ((System.Drawing.Image)(resources.GetObject("btnPepsi.Image")));
            this.btnPepsi.Location = new System.Drawing.Point(733, 236);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(146, 185);
            this.btnPepsi.TabIndex = 3;
            this.btnPepsi.Text = "Pepsi";
            this.btnPepsi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPepsi_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 25;
            this.lstProducts.Location = new System.Drawing.Point(318, 48);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(391, 329);
            this.lstProducts.TabIndex = 4;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(314, 405);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(185, 23);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "Total Amount: £0.00";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(527, 405);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(182, 23);
            this.lblPaidAmount.TabIndex = 6;
            this.lblPaidAmount.Text = "Paid Amount: £0.00";
            // 
            // btnOnePound
            // 
            this.btnOnePound.Image = ((System.Drawing.Image)(resources.GetObject("btnOnePound.Image")));
            this.btnOnePound.Location = new System.Drawing.Point(134, 457);
            this.btnOnePound.Name = "btnOnePound";
            this.btnOnePound.Size = new System.Drawing.Size(112, 111);
            this.btnOnePound.TabIndex = 7;
            this.btnOnePound.UseVisualStyleBackColor = true;
            this.btnOnePound.Click += new System.EventHandler(this.btnOnePound_Click);
            // 
            // btnFivePound
            // 
            this.btnFivePound.Image = ((System.Drawing.Image)(resources.GetObject("btnFivePound.Image")));
            this.btnFivePound.Location = new System.Drawing.Point(274, 457);
            this.btnFivePound.Name = "btnFivePound";
            this.btnFivePound.Size = new System.Drawing.Size(197, 111);
            this.btnFivePound.TabIndex = 8;
            this.btnFivePound.UseVisualStyleBackColor = true;
            this.btnFivePound.Click += new System.EventHandler(this.btnFivePound_Click);
            // 
            // btnTenPound
            // 
            this.btnTenPound.Image = ((System.Drawing.Image)(resources.GetObject("btnTenPound.Image")));
            this.btnTenPound.Location = new System.Drawing.Point(498, 457);
            this.btnTenPound.Name = "btnTenPound";
            this.btnTenPound.Size = new System.Drawing.Size(197, 111);
            this.btnTenPound.TabIndex = 9;
            this.btnTenPound.UseVisualStyleBackColor = true;
            this.btnTenPound.Click += new System.EventHandler(this.btnTenPound_Click);
            // 
            // btnTwentyPound
            // 
            this.btnTwentyPound.Image = ((System.Drawing.Image)(resources.GetObject("btnTwentyPound.Image")));
            this.btnTwentyPound.Location = new System.Drawing.Point(716, 457);
            this.btnTwentyPound.Name = "btnTwentyPound";
            this.btnTwentyPound.Size = new System.Drawing.Size(196, 111);
            this.btnTwentyPound.TabIndex = 10;
            this.btnTwentyPound.UseVisualStyleBackColor = true;
            this.btnTwentyPound.Click += new System.EventHandler(this.btnTwentyPound_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(229, 597);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(169, 55);
            this.btnCheckout.TabIndex = 11;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(437, 597);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 55);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(648, 597);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 55);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // VendingMachineapp
            // 
            this.ClientSize = new System.Drawing.Size(1018, 693);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnTwentyPound);
            this.Controls.Add(this.btnTenPound);
            this.Controls.Add(this.btnFivePound);
            this.Controls.Add(this.btnOnePound);
            this.Controls.Add(this.lblPaidAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnPepsi);
            this.Controls.Add(this.btnSoda);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.btnWater);
            this.Name = "VendingMachineapp";
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btnSoda;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Button btnOnePound;
        private System.Windows.Forms.Button btnFivePound;
        private System.Windows.Forms.Button btnTenPound;
        private System.Windows.Forms.Button btnTwentyPound;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}
