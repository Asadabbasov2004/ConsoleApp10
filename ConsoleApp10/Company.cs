using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp10
{
    internal class Company
    {
        public string Name { set; get; }
        User[] users =new User[0];
        public string Password;

        public void Register()
        {
            //string Name, string Surname , string Password
            Console.WriteLine("Zehmet olmasa adiniz girin");
           string Name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa soyadiniz girin");
          string   Surname = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa user name qeyd et");
            string UserName = Name+Surname ;
            Console.WriteLine("Zehmet olmasa passwordu  girin");
            while (true)
            {
               Password = Console.ReadLine();
                if (Password.Length > 5)
                {
                    // string UserName = null;
                    User user =new User ();
                    Console.WriteLine("succesful");
                    Array.Resize(ref users, users.Length + 1);
                    users[users.Length-1] = user;
                    break;
                }
                Console.WriteLine("zehmet olmasa passwordu 5 herfden cox yazin");
            }
            string Email = Name + "." + Surname + "@gmail.com";

      
        }
        public void Login()
        {
            //string Password,string Username
         
             
          Console.WriteLine("zehmet olmasa username gir");
            Console.WriteLine("dayandirmaq ucun stop yaz");

            while (true)
            {
                string Username1 = Console.ReadLine();
                if (Username1 == "stop")
                {
                    break;
                }
                if (Username1 == Username)
                {
                    Console.WriteLine("zehmet olmasa password gir");
                    while (true)
                    {
                        string password1 = Console.ReadLine();
                        if (password1 == Password)
                        {
                            Console.WriteLine("Kod duzdur");
                            break;
                        }
                        Console.WriteLine("password duz gir");
                    }
                    break;
                }
                Console.WriteLine("Error");
                Console.WriteLine("tezden daxil et");
            }

        }

        public void GetALl()
        {
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ,{user.Surname} ");
            }
        }
        public void contains()
        {
                Console.WriteLine("zehmet olmasa axatardiginiz adi girin");
            string search =Console.ReadLine();
            foreach  (User user in users )
            {
                if (user.Username == search )
                {
                    Console.WriteLine($"{user.Name} ");
                }
            }
        }
        public void Delete()
        {

        }
    }
}
