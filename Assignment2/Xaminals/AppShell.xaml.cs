using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xaminals.Data;
using Xaminals.Helpers;
using Xaminals.Views;

namespace Xaminals
{
    public partial class AppShell : Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>((url) => Device.OpenUri(new Uri(url)));
        public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());


        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();

            BindingContext = this;
        }

         void SignOutHandle_Clicked(object sender, System.EventArgs e)
        {
            Settings.ClearAllData();
             Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        void RegisterRoutes()
        {
            routes.Add("fruitdetails", typeof(FruitDetailPage));
            routes.Add("vegetabledetails", typeof(VegetableDetailPage));
            routes.Add("userprofile", typeof(UserProfilePage));
            routes.Add("chat", typeof(ChatPage));


            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async void ShowEmployeeDetails(int selectedUserID)
        {
            string username = "1";
            await Shell.Current.GoToAsync($"userprofile?id={username}");
        }

        async Task NavigateToRandomPageAsync()
        {
            string destinationRoute = routes.ElementAt(rand.Next(0, routes.Count)).Key;
            string groceryName = null;

            switch (destinationRoute)
            {
                case "fruitdetails":
                    groceryName = FruitData.Fruits.ElementAt(rand.Next(0, FruitData.Fruits.Count)).Name;
                    break;
                case "vegetabledetails":
                    groceryName = FruitData.Fruits.ElementAt(rand.Next(0, VegetableData.Vegetables.Count)).Name;
                    break;
            }

            ShellNavigationState state = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?name={groceryName}");
            Shell.Current.FlyoutIsPresented = false;
        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            // Cancel any back navigation
            //if (e.Source == ShellNavigationSource.Pop)
            //{
            //    e.Cancel();
            //}
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }
    }
}
