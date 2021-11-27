using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WzorzecFasada
{
    interface IUserService
    {
        void CreateUser(string email);
        void RemoveUser(string email);
        int Count { get; }
    }

    static class EmailNotification
    {
        public static void SendEmail(string to, string subject)
        {
            Console.WriteLine($"{subject} {to}");
        }
    }

    class UserRepository
    {
        private readonly List<string> users = new List<string>
        {
            "john.doe@gmail.com", "sylvester.stallone@gmail.com"
        };

        public bool IsEmailFree(string email)
        {
            return !users.Contains(email);
        }

        public void AddUser(string email)
        {
            users.Add(email);
        }

        public void RemoveUser(string email)
        {
            if (users.Contains(email))
            {
                users.Remove(email);
            }
        }

        public int Count { get { return users.Count; } }
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
                throw new ArgumentException("Błędny email");
            }

            if (!userRepository.IsEmailFree(email))
            {
                throw new ArgumentException("Adres email jest zajęty");
            }

            userRepository.AddUser(email);
            EmailNotification.SendEmail(email, "Welcome to our service");
        }

        public void RemoveUser(string email)
        {
            if (!userRepository.IsEmailFree(email))
            {
                userRepository.RemoveUser(email);
                EmailNotification.SendEmail(email, "Good bye");
            }
            else
            {
                throw new ArgumentException("Adresu email nie ma w bazie");
            }
        }

        // liczba emaili w bazie
        public int Count { get { return userRepository.Count; } }
    }

    class Program40
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
            Console.WriteLine($"Aktualna liczba adresów: {userService.Count}");
            userService.CreateUser("someemail@gmail.com");
            Console.WriteLine($"Aktualna liczba adresów: {userService.Count}");
            userService.RemoveUser("john.doe@gmail.com");
            Console.WriteLine($"Aktualna liczba adresów: {userService.Count}");


        }
    }

}