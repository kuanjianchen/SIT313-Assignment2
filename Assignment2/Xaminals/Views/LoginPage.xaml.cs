using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {

            InitializeComponent();

            BindingContext = new LoginUserViewModel();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

    }
}
