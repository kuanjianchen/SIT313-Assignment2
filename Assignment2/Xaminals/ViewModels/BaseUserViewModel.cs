using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using FluentValidation;
using Xamarin.Forms;
using Xaminals.Models;
using Xaminals.Servcies;
using Xaminals.Services;
using Xaminals.Views;

namespace Xaminals.ViewModels
{

        public class BaseUserViewModel : INotifyPropertyChanged
        {

            public User _user;


        public INavigation _navigation;
            public IValidator _userValidator;
            public IUserRepository _userRepository;

            public BaseUserViewModel()
            {
                _userValidator = new UserValidator();
                _user = new User();
                _userRepository = new UserRepository();
               
            }

        public string UserName
        {
            get => _user.UserName;
            set
            {
                _user.UserName = value;
                NotifyPropertyChanged("UserName");
            }
        }

        public string Name
        {
            get => _user.Name;
            set
            {
                _user.Name = value;
                NotifyPropertyChanged("Name");
            }
        }


        public string PhoneNumber
        {
            get => _user.PhoneNumber;
            set
            {
                _user.PhoneNumber = value;
                NotifyPropertyChanged("PhoneNumber");
            }
        }


        public string Email
        {
            get => _user.Email;
            set
            {
                _user.Email = value;
                NotifyPropertyChanged("Email");
            }
        }


        public string Password
        {
            get => _user.Password;
            set
            {
                _user.Password = value;
                NotifyPropertyChanged("Password");
            }
        }

        public string ConfirmPassword
        {
            get => _user.ConfirmPassword;
            set
            {
                _user.ConfirmPassword = value;
                NotifyPropertyChanged("ConfirmPassword");
            }
        }

       

        public string Gender
        {
            get => _user.Gender;
            set
            {
                _user.Gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        public DateTime BirthDate
        {
            get => _user.BirthDate;
            set
            {
                _user.BirthDate = value;
                NotifyPropertyChanged("BirthDate");
            }
        }

        public string Address
        {
            get => _user.Address;
            set
            {
                _user.Address = value;
                NotifyPropertyChanged("Address");
            }
        }



        #region INotifyPropertyChanged      
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }
}
