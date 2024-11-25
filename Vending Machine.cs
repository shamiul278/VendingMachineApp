using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VendingMachineApp{
    public partial class VendingMachineapp : Form  {
        private decimal totalAmount = 0;
        private decimal paidAmount = 0;
        private Dictionary<string, decimal> products = new Dictionary<string, decimal>   {{ "Mineral Water", 1.00m },{ "Coke", 1.50m }, { "Soda", 1.20m }, { "Pepsi", 1.50m }};

        public VendingMachineapp()  {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            InitializeUI();
        }

        private void InitializeUI()  {
            btnWater.Text = $"Mineral Water - £{products["Mineral Water"]:F2}";
            btnCoke.Text = $"Coke - £{products["Coke"]:F2}";
            btnSoda.Text = $"Soda - £{products["Soda"]:F2}";
            btnPepsi.Text = $"Pepsi - £{products["Pepsi"]:F2}";

            btnCheckout.Enabled = true;
            btnClear.Enabled = true;
            EnableProductButtons(true);
            EnableCoinButtons(false);
        }

        private void EnableProductButtons(bool enabled)   {
            btnWater.Enabled = enabled;
            btnCoke.Enabled = enabled;
            btnSoda.Enabled = enabled;
            btnPepsi.Enabled = enabled;
        }

        private void EnableCoinButtons(bool enabled) {
            btnOnePound.Enabled = enabled;
            btnFivePound.Enabled = enabled;
            btnTenPound.Enabled = enabled;
            btnTwentyPound.Enabled = enabled;
        }

        private void AddProductToOrder(string productName) {

            lstProducts.Items.Add($"{productName} - £{products[productName]:F2}");

            totalAmount += products[productName];
                lblTotalAmount.Text = "Total Amount: £" + totalAmount.ToString("F2");
        }

        private void btnWater_Click(object sender, EventArgs e) 
            => AddProductToOrder("Mineral Water");
        private void btnCoke_Click(object sender, EventArgs e) 
            => AddProductToOrder("Coke");
        private void btnSoda_Click(object sender, EventArgs e) 
            => AddProductToOrder("Soda");
        private void btnPepsi_Click(object sender, EventArgs e) 
            => AddProductToOrder("Pepsi");

        private void btnCheckout_Click(object sender, EventArgs e) {
            EnableProductButtons(false);
            EnableCoinButtons(true);
            MessageBox.Show("Please pay the total amount.");
        }

        private void PayAmount(decimal amount) {
            paidAmount += amount;
            lblPaidAmount.Text = "Paid Amount: £" + paidAmount.ToString("F2");

            if (paidAmount >= totalAmount) {
                decimal change = paidAmount - totalAmount;
                MessageBox.Show("Payment complete! Your change is £" + change.ToString("F2"));
                ResetVendingMachine();
            }
        }

        private void btnOnePound_Click(object sender, EventArgs e)
            => PayAmount(1.00m);
        private void btnFivePound_Click(object sender, EventArgs e) 
            => PayAmount(5.00m);
        private void btnTenPound_Click(object sender, EventArgs e) 
            => PayAmount(10.00m);
        private void btnTwentyPound_Click(object sender, EventArgs e) 
            => PayAmount(20.00m);

        private void ResetVendingMachine() {
            totalAmount = 0;
            paidAmount = 0;
            lstProducts.Items.Clear();
            lblTotalAmount.Text = "Total Amount: £0.00";
            lblPaidAmount.Text = "Paid Amount: £0.00";
            EnableProductButtons(true);
            EnableCoinButtons(false);
        }

        private void btnClear_Click(object sender, EventArgs e) 
            => ResetVendingMachine();

        private void btnCancel_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Cancel Order", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                ResetVendingMachine();
            }
        }
    }
}
