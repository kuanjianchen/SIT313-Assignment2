using System;  
using Xamarin.Forms;  
using Xaminals.iOS;  
using System.IO;
using SQLite.Net;
using Xaminals.Helpers;

[assembly:Dependency(typeof(ISQLiteDbInterface_iOS))]  
namespace Xaminals.iOS
{
    public class ISQLiteDbInterface_iOS  : ISQLite {
                public SQLiteConnection GetConnection()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, DatabaseHelper.DbFileName);
            // Create the connection
            var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var conn = new SQLiteConnection(plat, path);
            // Return the database connection
            return conn;
        }
    }
}