﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new AddUserViewModel();
        }


    }
}
