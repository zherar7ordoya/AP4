﻿using System.Windows;

namespace UIInsumosOficina
{
    public partial class ItemDialogo : Window
    {
        public ItemDialogo()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}