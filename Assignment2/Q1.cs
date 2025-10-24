using System;

namespace Assignment2
{
    class UserProfile
    {
        private string username = "";
        private string password;
        private string email;

        internal void Set(string username, string password, string email)
        {
            this.username = username;

            if (ValidatePassword(password))
            {
                this.password = password;
            }

            if (ValidateEmail(email))
            {
                this.email = email;
            }
        }

        internal void Get()
        {
            Console.WriteLine("Username: " + this.username);
            Console.WriteLine("Password: " + this.password);
            Console.WriteLine("Email: " + this.email);
        }

        internal bool ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Email is empty");
                return false;
            }
            else if (!email.Contains("@"))
            {
                Console.WriteLine("Email is not valid");
                return false;
            }
            return true;
        }

        internal bool ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("Password is invalid");
                return false;
            }
            return true;
        }
    }

    internal class Q1
    {
        static void Main(string[] args)
        {
            UserProfile profile = new UserProfile();
            profile.Set("aditya", "185we", "abcgmail.com");
            profile.Get();
        }
    }
}
