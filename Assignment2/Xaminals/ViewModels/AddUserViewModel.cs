using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using FluentValidation;
using Xamarin.Forms;
using Xaminals.Helpers;
using Xaminals.Models;
using Xaminals.Servcies;
using Xaminals.Services;
using Xaminals.Views;

namespace Xaminals.ViewModels
{
    public class AddUserViewModel : BaseUserViewModel
    {

        public ICommand RegisterCommand { get; set; }

       
        public AddUserViewModel()
        {
            _userValidator = new UserValidator();
            _user = new User();
            _userRepository = new UserRepository();
            RegisterCommand = new Command(async () => await RegisterUser()); 
        }

       
        async Task RegisterUser()
        {
            var validationResults = _userValidator.Validate(_user);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Add User", "Do you want to save User details?", "OK", "Cancel");
                if (isUserAccept)
                {
                    try
                    {
                        var result = _userRepository.InsertUser(_user);
                        if (result == 1)
                        {
                            await Application.Current.MainPage.DisplayAlert("GroceryApp", "Registration Successful..!!" + Environment.NewLine + "Please Login", "Ok");
                            Application.Current.MainPage = new LoginPage();
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        var error = ex.Message + "UserName must be unique.";

                        await Application.Current.MainPage.DisplayAlert("GroceryApp", error, "Ok");
                    }
                   
                }
            }
            else
            {
               await Application.Current.MainPage.DisplayAlert("GroceryApp", validationResults.Errors[0].ErrorMessage, "Ok");
             }
        }


        
    }
}
