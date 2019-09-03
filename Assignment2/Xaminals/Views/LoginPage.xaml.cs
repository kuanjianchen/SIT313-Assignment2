using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xaminals.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            //var user = new User
            //{
            //    Username = usernameEntry.Text,
            //    Password = passwordEntry.Text
            //};

            //var isValid = AreCredentialsCorrect(user);
            //if (isValid)
            //{
            //    App.IsUserLoggedIn = true;

            //            MainPage = new AppShell();

            // if it ie MasterController/Drawer view/flyout menu/menu view
            Application.Current.MainPage = new AppShell(); // need to create a page in the type 'MasterDetailPage' 



            //Navigation.InsertPageBefore(new AppShell(), this);
            //await Navigation.PopAsync();
            //}
            //else
            //{
            //    messageLabel.Text = "Login failed";
            //    passwordEntry.Text = string.Empty;
            //}
        }

        //bool AreCredentialsCorrect(User user)
        //{
        //    return user.Username == Constants.Username && user.Password == Constants.Password;
        //}
    }
}
