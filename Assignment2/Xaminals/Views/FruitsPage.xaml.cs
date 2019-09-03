using System.Linq;
using Xamarin.Forms;
using Xaminals.Models;

namespace Xaminals.Views
{
    public partial class FruitsPage : ContentPage
    {
        public FruitsPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fruitName = (e.CurrentSelection.FirstOrDefault() as Grocery).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"fruitdetails?name={fruitName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/monkeys/monkeydetails?name={monkeyName}");
        }
    }
}
