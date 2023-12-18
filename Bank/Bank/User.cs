using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public enum UserRole
    {
        User,
        Admin
    }
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PersonalNumber { get; set; } 
        public UserRole Role { get; set; }
        public List<Account> Accounts { get; set; }
        private static List<User> users = new List<User>();

        public User(string name, string password, string email, string personalNumber, UserRole role)
        {
            Name = name;
            Password = password;
            Email = email;
            PersonalNumber = personalNumber;
            Role = role;
            Accounts = new List<Account>();
            users.Add(this);
        }
        public static List<User> GetUsers()
        {
            return users;
        }
    }
}
