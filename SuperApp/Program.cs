using System;

namespace SuperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Podaj nazwę:");
            string name = Console.ReadLine();

            Console.Out.WriteLine("Podaj email:");
            string email = Console.ReadLine();

            Console.Out.WriteLine("Podaj numer telefonu:");
            string phoneNumber = Console.ReadLine();

            var service = new DataService(new UserRepository(), new SmsSender());
            //var service = new DataService();
            // service.sender = new SmsSender();
            // service.repository = new UserRepository();
            service.CreateUserAccount(name, email, phoneNumber);
        }
    }
}
