﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class Program
    {
        static readonly ShoppingCartModel cart = new ShoppingCartModel();

        static void Main()
        {
            PopulateCartWithDemoData();
            WriteLine($"2) Total: \t {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");

            decimal total = cart.GenerateTotal(
                (sub) => WriteLine($"\n\nCart 2 sub: \t {sub:C}"),
                (products, sub) =>
                {
                    if (products.Count > 3) return sub * 0.5M;
                    else return sub;
                },
                (message) => WriteLine($"Cart 2 alert: \t { message }")
                );
            WriteLine($"Cart 2 total: \t {total:C}");

            ReadKey();
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }

        private static void SubTotalAlert(decimal subTotal) => WriteLine($"1) Subtotal: \t {subTotal:C2}");

        private static void AlertUser(string message) => WriteLine(message);

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100) return subTotal * 0.80M;
            else if (subTotal > 50) return subTotal * 0.85M;
            else if (subTotal > 10) return subTotal * 0.90M;
            else return subTotal;
        }
    }
}
