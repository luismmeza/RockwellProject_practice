using System;
using System.Collections.Generic;
using System.Text;

namespace RockwellCS.UserInterface
{
    public static class UI
    {
        public static void SetMainMenuTitle(UserModel user) 
        {
            Console.Title = $"Welcome Mr. {user.Name}";
        }
        public static void MainMenuPrompt()
        {
            Console.Clear();
            Console.WriteLine("0. \t Log Out");
            Console.WriteLine("1. \t Object Lesson");
            Console.WriteLine(" ");
        }

        public static string GetMenuInput()
        {
            MainMenuPrompt();
            return Console.ReadLine();
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static UserModel GetUserModel(UserModel nillUser) 
        {
            Console.Clear();
            Console.Title = "Sign In";
            Console.WriteLine("Please Sign In");
            Console.WriteLine("Username");
            string username = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            Console.Clear();

            nillUser.username = username;
            nillUser.password = password;

            return nillUser;
        }

        public static int ObjectLessonMenu() 
        {
            Console.WriteLine("1. \t Generate New Container");
            Console.WriteLine("2. \t Generate New Container and Add it to the List");
            Console.WriteLine("3. \t Display all Container Types and Capacities.");

            string answer = Console.ReadLine();
            int choice = ValidateAnswer(1, 3, answer);

            return choice;
        }

        public static int ValidateAnswer(int min, int max, string choice) 
        {
            int answer = -500;

            try 
            {
               answer = Convert.ToInt32(choice);
                if (answer >= min && answer <= max) 
                { 
                    return answer; 
                }
                else 
                {
                    return answer;
                }
            }
            catch (Exception e) 
            {
                return answer;
            }
        }
    }
}
