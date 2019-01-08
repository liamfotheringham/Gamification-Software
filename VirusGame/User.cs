using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusGame
{
    public class User
    {
        public string Username { get; set; }
        public int isAdmin { get; set; }
        public User(string username, int isadmin)
        {
            Username = username;
            isAdmin = isadmin;
        }
    }
}
