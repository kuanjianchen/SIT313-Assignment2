using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using Xaminals.Models;

namespace Xaminals.Helpers
{
    public class DatabaseHelper
    {

        static SQLiteConnection sqliteconnection;
        public const string DbFileName = "Users.db";

        public DatabaseHelper()
        {
            sqliteconnection = DependencyService.Get<ISQLite>().GetConnection();
            sqliteconnection.CreateTable<User>();
        }

        // Get All User data      
        public List<User> GetAllUsersData()
        {
            return (from data in sqliteconnection.Table<User>()
                    select data).ToList();
        }

        //Get Specific User data  
        public User GetUserData(string userName)
        {
            return sqliteconnection.Table<User>().FirstOrDefault(t => t.UserName == userName);
        }

        //Get Login User data  
        public User GetLoginUserData(string userName , string password)
        {
            return sqliteconnection.Table<User>().FirstOrDefault(t => t.UserName == userName &&  t.Password == password);
        }

        // Delete all Users Data  
        public void DeleteAllUsers()
        {
            sqliteconnection.DeleteAll<User>();
        }

        // Delete Specific User  
        public void DeleteUser(int id)
        {
            sqliteconnection.Delete<User>(id);
        }

        // Insert new User to DB   
        public int InsertUser(User contact)
        {
            return sqliteconnection.Insert(contact);
        }

        // Update User Data  
        public int UpdateUser(User contact)
        {
           return  sqliteconnection.Update(contact);
        }
    }
}
