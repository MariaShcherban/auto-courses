using System;

namespace Authentification
{
    class Authentification
    {
        private const string userName = "admin";
        private const string password = "a";
        private const int numberOfAttempts = 3;

        public bool CheckUserCredentials(string login, string pswd)
        {
            if (login.Equals(userName) && pswd.Equals(password))
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            Authentification authentification = new Authentification();
            string usernameAttempt, passwordAttempt;
            bool isLoginSuccessfull = false;

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.WriteLine("Enter username");
                usernameAttempt = Console.ReadLine();
                Console.WriteLine("Enter password");
                passwordAttempt = Console.ReadLine();
                isLoginSuccessfull = authentification.CheckUserCredentials(usernameAttempt, passwordAttempt);
                if (isLoginSuccessfull)
                {
                    Console.WriteLine("Welcome back, {0}", usernameAttempt);
                    break;
                }
                else
                    Console.WriteLine("Username or password is incorrect");
                    
            }
            if (!isLoginSuccessfull)
            {
                Console.WriteLine("User credentials are incorrect. Press any key to close the application");
                Console.Read();
            }
        }
    }
}
