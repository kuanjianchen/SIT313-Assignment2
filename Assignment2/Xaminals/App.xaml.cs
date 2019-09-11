using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Helpers;
using Xaminals.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xaminals
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();

            // Check is the app running for the first time         
            if (IsFirstTime == "yes")
            {

                MainPage = new NavigationPage(new LoginPage());

            }
            else
            {
                MainPage = new AppShell();
            }
        }

        //logout
        //Application.Current.MainPage = new NavigationPage(new LoginPage());

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public string IsFirstTime
        {
            get { return Settings.GeneralSettings; }
            set
            {
                if (Settings.GeneralSettings == value)
                    return;
                Settings.GeneralSettings = value;
                OnPropertyChanged();
            }
        }
    }
}
