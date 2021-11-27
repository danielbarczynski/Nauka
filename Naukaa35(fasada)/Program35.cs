using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WzorzecFasada
{

    interface IUserService
    {
        void CreateUser(string email);
    }

    static class EmailNotification
    {
        public static void SendEmail(string welcome, string user) // notyfikacja sie nie wysylala, bo przeciez te zmienne nie byly nigdzie przypisane
        {            
            Console.WriteLine($"{welcome} {user}");           
        }
    }

    class UserRepository
    {
        public static List<string> users = new List<string>
        {
            "john.doe@gmail.com", "sylvester.stallone@gmail.com"
        };

        public static bool IsEmailFree(string email) 
        {
            if (users.Contains(email))
            {
                return true;// jesli zawiera mail (true) zwroci go metodzie
            }
            else
            {
                return false;
            }
        }

        public void AddUser(string email)
        {
            users.Add(email);            
        }

        public void DeleteUser(string email)
        {
            users.Remove(email);
        }

        public bool Exist(string email)
        {
            if (users.Contains(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListOfUsers() // na mój użytek
        {
            Console.WriteLine("\nAll users:");

            foreach (var x in users)
            {
                Console.WriteLine(x);
            }
        }
    }

    static class Validators
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
        }
    }

    class UserService : IUserService
    {
        private readonly UserRepository userRepository = new UserRepository();

        public void CreateUser(string email)
        {
            if (!Validators.IsValidEmail(email))
            {
                throw new ArgumentException("The email is not valid"); // do siebie: "the email" zamiast "an email" ponieważ mówimy o konkretnym adresie email
            }
            if (UserRepository.IsEmailFree(email)) // usunąłem negacje
            {
                throw new ArgumentException("The email is already taken"); // metoda odbiera info o duplikacie, wyrzuca błąd
            }

            userRepository.AddUser(email);
            EmailNotification.SendEmail("Welcome to our service", email); // string welcome, string user
            userRepository.ListOfUsers(); // na mój użytek // update: okazuje się, że potrzebna przy usuwaniu, haha
        }

        public void DeleteUser(string email)
        {
            if (!userRepository.Exist(email))
            {
                throw new ArgumentException("This email does not exist");
            }
            userRepository.DeleteUser(email);
            EmailNotification.SendEmail("Your account has been deleted", email);
            userRepository.ListOfUsers();
        }

    }

    class Program35
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.CreateUser("john.wick@gmail.com");
            //userService.CreateUser("john.wick@gmail.com"); // sprawdzalem czy wyrzuci błąd o duplikacie, wyrzuca
            //userService.CreateUser("smok tabaluga"); // sprawdzalem czy wyrzuci blad o błąd nazwie, wyrzuca
            Console.WriteLine();
            userService.DeleteUser("john.wick@gmail.com");
            //userService.DeleteUser("john.wick@gmail.com"); // sprawdzałem czy wyrzuca bład o nieistniejącym koncie, wyrzuca
        }
    }

}