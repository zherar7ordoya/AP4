﻿using System;
using System.Collections.Generic;
using UI.Mobile.ViewModels;
using UI.Mobile.Views;
using Xamarin.Forms;

namespace UI.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
