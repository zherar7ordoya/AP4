﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private void messageBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);
            MessageBox.Show($"Total: {total:C}");
        }

        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal(
                (sub) => subTotalTextBox.Text=$"{sub:C}",
                (products, sub) => sub - (products.Count * 2),
                (message) => { }
            );
            totalTextBox.Text = $"{total:C}";
        }

        // Métodos que se necesitan

        private void PrintOutDiscountAlert(string message) => MessageBox.Show(message);
        private void SubTotalAlert(decimal subtotal) => MessageBox.Show($"Subtotal: {subtotal:C}");
        private decimal CalculateLeveledDiscount(List<ProductModel> products, decimal subtotal) => subtotal - products.Count();
    }
}
