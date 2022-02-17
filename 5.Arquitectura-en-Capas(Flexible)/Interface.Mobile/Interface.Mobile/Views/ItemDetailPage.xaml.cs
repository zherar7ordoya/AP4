using Interface.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Interface.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}