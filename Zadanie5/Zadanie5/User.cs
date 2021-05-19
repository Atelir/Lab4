using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    public class User
    {
        public static List<User> Users = new List<User>();
        public string Login { get; set; }
        public string Haslo { get; set; }

        public User(string Nazwa, string Haslo)
        {
            this.Login = Nazwa;
            this.Haslo = Haslo;
        }

        public static void AddUserToList(User user)
        {
            Users.Add(user);
        }
    }

}
