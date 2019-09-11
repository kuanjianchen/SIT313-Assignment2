using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
            this.BindingContext = new UserDetailViewModel(Navigation);
        }
    }
}
