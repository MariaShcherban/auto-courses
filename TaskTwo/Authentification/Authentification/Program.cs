using System;

namespace Authentification
{
    class Program
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
            Program p = new Program();
            string usernameAttempt, passwordAttempt;
            bool isLoginSuccessfull = false;

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.WriteLine("Enter username");
                usernameAttempt = Console.ReadLine();
                Console.WriteLine("Enter password");
                passwordAttempt = Console.ReadLine();
                isLoginSuccessfull = p.CheckUserCredentials(usernameAttempt, passwordAttempt);
                if (isLoginSuccessfull)
                {
                    Console.WriteLine("User credentials are correct");
                    break;
                }
                else
                    Console.WriteLine("Username or password is incorrect. Please try again");
                    
            }
            if (!isLoginSuccessfull)
            {
                Console.WriteLine("User credentials are incorrect. Press any key to close the application");
                Console.Read();
            }
        }
    }
}
