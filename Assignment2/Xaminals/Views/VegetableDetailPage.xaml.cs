using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xaminals.Data;

namespace Xaminals.Views
{
    [QueryProperty("Name", "name")]
    public partial class VegetableDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = VegetableData.Vegetables.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public VegetableDetailPage()
        {
            InitializeComponent();
        }
    }
}

