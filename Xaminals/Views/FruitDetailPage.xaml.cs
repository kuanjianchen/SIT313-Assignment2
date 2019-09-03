using Xamarin.Forms;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class FruitDetailPage : ContentPage
    {
        public FruitDetailPage()
        {
            InitializeComponent();
            BindingContext = new FruitDetailViewModel();
        }
    }
}
