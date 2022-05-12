using System;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime Date { get; set; }

        public User()
        {
            Date = DateTime.Now;
        }

    //we actually dont need a constructor like this for model-binding. but, we'll want it if we want to code our own Users. Example: User newGuy = new User("zachary", "z@me", "B@n@n@C@t");
        //public User(string username, string email, string password) : this()
        //{
        //    Username = username;
        //    Email = email;
        //    Password = password;
        //}
    }
}