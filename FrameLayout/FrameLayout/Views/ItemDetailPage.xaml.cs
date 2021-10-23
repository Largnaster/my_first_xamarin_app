using FrameLayout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FrameLayout.Views
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