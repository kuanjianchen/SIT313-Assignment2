using System;
using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Services
{
    public interface IUserRepository
    {
        List<User> GetAllUsersData();

        //Get Specific User data  
        User GetUserData(string userName);

        //Login User   
        User LoginUser(string userName , string password);

        // Delete all Users Data  
        void DeleteAllUsers();

        // Delete Specific User  
        void DeleteUser(int userID);

        // Insert new User to DB   
        int InsertUser(User user);

        // Update User Data  
        int UpdateUser(User user);
    }
}