using System.Collections.Generic;
using Xaminals.Helpers;
using Xaminals.Models;
using Xaminals.Services;

namespace Xaminals.Servcies
{
    public class UserRepository : IUserRepository
    {
        DatabaseHelper _databaseHelper;
        public UserRepository()
        {
            _databaseHelper = new DatabaseHelper();
        }

        public void DeleteUser(int userID)
        {
            _databaseHelper.DeleteUser(userID);
        }

        public void DeleteAllUsers()
        {
            _databaseHelper.DeleteAllUsers();
        }

        public List<User> GetAllUsersData()
        {
            return _databaseHelper.GetAllUsersData();
        }

        public User GetUserData(string userName)
        {
            return _databaseHelper.GetUserData(userName);
        }

        public User LoginUser(string userName, string password)
        {
            return _databaseHelper.GetLoginUserData(userName, password);
        }

        public int InsertUser(User user)
        {
           return _databaseHelper.InsertUser(user);
        }

        public int UpdateUser(User user)
        {
           return _databaseHelper.UpdateUser(user);
        }

       
    }
}
