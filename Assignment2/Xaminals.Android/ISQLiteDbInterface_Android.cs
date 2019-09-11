using System.IO;
using Xaminals.Droid;
using SQLite.Net;
using Xamarin.Forms;
using Xaminals.Helpers;

[assembly: Dependency(typeof(ISQLiteDbInterface_Android))]
namespace Xaminals.Droid
{
    public class ISQLiteDbInterface_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            // Documents folder
            var path = Path.Combine(documentsPath, DatabaseHelper.DbFileName);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLiteConnection(plat, path);
            // Return the database connection
            return conn;
        }
    }
}
