using System;
using System.Linq;
using Xamarin.Forms;
using Xaminals.Data;

namespace Xaminals.Views
{

    [QueryProperty("Name", "name")]
    public partial class FruitDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = FruitData.Fruits.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public FruitDetailPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}