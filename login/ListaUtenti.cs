using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class ListaUtenti
    {
        public string Username { get; set; }    
        public string Password { get; set; }

        public DateTime Log { get; set; }

        public ListaUtenti() { }    

        public ListaUtenti(string username, string password, DateTime login) {
        this.Username = username;
            this.Password = password;
            this.Log = login;
        }
    }
}
