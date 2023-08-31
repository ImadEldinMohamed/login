using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal static class Utente
    {

        static string Username;
        static string Password;

        static bool logg = false;

        static DateTime Log;

        static List<ListaUtenti> listaUtenti = new List<ListaUtenti>();


        public static void Menu()
        {
            Console.WriteLine("===========menu===============");
            Console.WriteLine("scegli");
            Console.WriteLine("1 login");
            Console.WriteLine("2 logout");
            Console.WriteLine(" 3 ora e data login");
            Console.WriteLine("4 lista accessi");
            Console.WriteLine("5 esci");
            int scelta = int.Parse(Console.ReadLine());
            if (scelta == 1)
            {
                Login();
            }
            if (scelta == 2)
            {
                Logout();
            }

            if (scelta == 3)
            {
                Verificadataeora();
            }

            if (scelta == 4)
            {
                accessi();
            }
        }

        public static void Login()
        {
            Console.WriteLine("nome");
            Username = Console.ReadLine();
            Console.WriteLine("password");
            Password = Console.ReadLine();
            string ripeti = Console.ReadLine();
            if (ripeti != Password)
            {
                Console.WriteLine("sbagliato");
                Login();
            }
            Log = DateTime.Now;
            Console.WriteLine($"{Username} ok");
            Console.ReadLine();

        }

        public static void Logout()
        {
            if (logg)
            {
                logg = false;
                Console.WriteLine($"{Username} logout");
            }
        }

        public static void Verificadataeora()
        {
            if (logg)
            {
                Console.WriteLine($"L'Utente {Username} ha loggato in data {Log}");
            }
            else
            {
                Console.WriteLine("NO LOGIN");
            }
        }

        public static void accessi()
        {

            foreach(ListaUtenti x in listaUtenti)
            {
                Console.WriteLine($"{x.Username}DATA{x.Log} ");
            }
        }



    }
}
