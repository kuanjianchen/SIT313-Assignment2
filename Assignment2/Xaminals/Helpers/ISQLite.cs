using System;
using SQLite.Net;


namespace Xaminals.Helpers
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
