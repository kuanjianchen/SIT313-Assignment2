using System;
using SQLite.Net.Attributes;  
namespace Xaminals.Models
{
[Table("User")]  
    public class User
    {
            [PrimaryKey, AutoIncrement]  
            public int Id { get; set; }
            [Unique]  
            public string UserName { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
            public string Gender { get; set; }
            public DateTime BirthDate { get; set; }
            public string Address { get; set; }

    }
}
