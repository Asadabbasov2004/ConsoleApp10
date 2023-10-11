
namespace ConsoleApp10
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        string _password;
        public string Password;
        public string Email { get; set; }
    

        public void Register()
        {
            Console.WriteLine("Zehmet olmasa adiniz girin");
            Name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa soyadiniz girin");
            Surname = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa passwordu  girin");
            while (true)
            {
            Password = Console.ReadLine();
                if (Password.Length > 5)
                {
                    break;
                }
                Console.WriteLine("zehmet olmasa passwordu 5 herfden cox yazin");
            }
             Email = Name + "." + Surname + "@gmail.com" ;

            string[] arr = {Name,Surname, 
                Email, Password , Username ="asad04"};  

     }
        public void Login()
        {
            Console.WriteLine("zehmet olmasa username gir");
            Console.WriteLine("dayandirmaq ucun stop yaz");

            while (true)
            {
                string Username1 = Console.ReadLine();
                if (Username1 == "stop"){
                    break;
                    }
                if (Username1 == Username)
                {
                        Console.WriteLine("zehmet olmasa password gir");
                    while (true)
                    {
                    string password1 = Console.ReadLine();
                    if(password1 == Password)
                    {
                            Console.WriteLine($"adin {Name}  soyad {Surname} username {Username}  kod {Password}");
                        break ;
                    }
                        Console.WriteLine("password duz gir");
                    }
                break;
                }
                    Console.WriteLine("Error");
                Console.WriteLine("tezden daxil et");
            }

        }

    }
}
