using FrameLayout.Models;
using FrameLayout.ViewModels;
using FrameLayout.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrameLayout.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;
        public List<Models.Model> Models = new List<Models.Model>();

        public ItemsPage()
        {
            InitializeComponent();
            this.Models = new List<Models.Model>();
            Models.Model model = new Models.Model()
            {
                description = "Esto es un elemento de la lista"
            };

            this.Models.Add(model);
            this.modelos.ItemsSource = this.Models;

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}