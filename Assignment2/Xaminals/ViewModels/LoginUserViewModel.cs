using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xaminals.Helpers;
using Xaminals.Models;
using Xaminals.Servcies;
using Xaminals.Views;

namespace Xaminals.ViewModels
{
    public class LoginUserViewModel : BaseUserViewModel
    {
        public ICommand LoginUserCommand { get; private set; }

        public LoginUserViewModel()
        {
            _userValidator = new LoginUserValidator();
            _user = new User();
            _userRepository = new UserRepository();
            LoginUserCommand = new Command(async () => await LoginUser());
        }

        async Task LoginUser()
        {
           
            var validationResults = _userValidator.Validate(_user);

            if (validationResults.IsValid)
            {
                var result = _userRepository.LoginUser(_user.UserName, _user.Password);

                if ( result != null)
                {
                    // save user preference 
                    Settings.UserName = _user.UserName;
                    Settings.Password = _user.Password;
                    Settings.GeneralSettings = "no";
                     Application.Current.MainPage = new AppShell();
                }
                else 
                {
                    await Application.Current.MainPage.DisplayAlert("GroceryApp", "Invalid Login Details", "Ok");

                    //Application.Current.MainPage = new LoginPage();
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("GroceryApp", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }
    }
}
