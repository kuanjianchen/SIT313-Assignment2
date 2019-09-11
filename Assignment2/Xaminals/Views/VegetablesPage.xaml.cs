using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xaminals.Models;

namespace Xaminals.Views
{
    public partial class VegetablesPage : ContentPage
    {
        public VegetablesPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string vegetableName = (e.CurrentSelection.FirstOrDefault() as Grocery).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"vegetabledetails?name={vegetableName}");

        }
    }
}
