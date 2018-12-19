using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionnelle_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("login");
            string login = (Console.ReadLine());
            Console.WriteLine("mot de passe");
            string password = (Console.ReadLine());
            if (login == "mike" && password == "m1k3")
            {
                Console.WriteLine("Bienvenue à la Manu le Havre");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe");
            }
        }
    }
}
