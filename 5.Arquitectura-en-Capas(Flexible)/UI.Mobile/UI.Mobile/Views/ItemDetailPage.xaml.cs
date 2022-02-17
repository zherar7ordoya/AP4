using System.ComponentModel;
using UI.Mobile.ViewModels;
using Xamarin.Forms;

namespace UI.Mobile.Views
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