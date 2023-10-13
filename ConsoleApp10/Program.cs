using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check =true ;
            Company company = new Company();
            do
            {
            Console.WriteLine("welcome ,please enter some value");
                Console.WriteLine("1.Register a user to company");
                Console.WriteLine("2 .Login a user to company");
                Console.WriteLine("3.See all users in a company(GetAll)");
                Console.WriteLine("4.Get one user by username (GetByUserName)");
                Console.WriteLine("5.Uptade user;s data (UptadeByUserName)");
                Console.WriteLine("6.Delete user from compant");
                Console.WriteLine("7.exit");
                string num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        company.Register();
                    break;
                    case "2":
                        company.Login();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;

                }
            }while (check);
        }
    }
}