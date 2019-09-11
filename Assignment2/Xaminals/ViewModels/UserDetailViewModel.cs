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
    public class UserDetailViewModel : BaseUserViewModel
    {

        public ICommand UpdateUserCommand { get; private set; }
       
        public UserDetailViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _user = new User();
            _userRepository = new UserRepository();
            GetUserDetails(Settings.UserName);
            UpdateUserCommand = new Command(async () => await UpdateUser());
          
        }
        void GetUserDetails(string userName)
        {
            _user = _userRepository.GetUserData(userName);
        }


        async Task UpdateUser()
        {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("User Details", "Update User Details", "OK", "Cancel");
                if (isUserAccept)
                {
                 var result =  _userRepository.UpdateUser(_user);
                if (result == 1)
                {
                    await Application.Current.MainPage.DisplayAlert("User Details", "User Details Updated", "OK");
                }
               
            }
        }



    }
}
