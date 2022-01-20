using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using EfDatabaseFirst;

namespace EfDatabaseFirst
{
    public static class Application
    {
        public static void Japa()
        {            
            var menu = new StringBuilder();
            Clear();
            menu.Append("Hello!!! Welcome to Slimcent Operations \n");
            menu.AppendLine("Select The operation you want to perform\n");
            menu.Append("Press 1 to Show All Users\n");
            menu.Append("Press 2 Find a User by Id\n");
            menu.Append("Press 3 Delete a User by Id\n");
            menu.Append("Press 4 Update a User by Id\n");
            menu.Append("Press 5 Add a new User\n");
            menu.Append("Press 6 to Exit\n");
            WriteLine(menu.ToString());
            var selection = ReadLine();

            while (selection != "1" && selection != "2" && selection != "3" && selection != "4" && selection != "5" && selection != "6")
            {
                Validation.ValEnglish.InvalidPrompt(selection);
                selection = ReadLine();
            }

            switch (selection)
            {
                case "1":
                CrudOperation.ShowAllUsers();
                    break;
                case "2":
                CrudOperation.FindUser(1);
                    break;
                case "3":
                CrudOperation.DeleteUser(2);
                    break;
                case "4":
                CrudOperation.UpdateUser(1);
                    break;
                case "5":
                CrudOperation.AddNewUser();
                        break;
                case "6":
                        Exit("6");
                    break;
                default:
                WriteLine("Invalid selection made, Chose the right option");
                    break;
            }
        }

        public static void WhatElseToPerform()
        {
            var otherOptions = new StringBuilder();
            otherOptions.Append("Thank you for Visiting Slimcent today \n");
            otherOptions.AppendLine("What else do you want to do?\n");
            otherOptions.Append("Press 1 to go back to the Main Menu\n");
            otherOptions.Append("Press 6 to Exit\n");
            WriteLine(otherOptions.ToString());
            var selected = ReadLine();

            while (selected != "1" && selected != "6")
            {
                Validation.ValEnglish.InvalidPrompt(selected);
                selected = ReadLine();
            }

            switch (selected)
            {
                case "1":
                    Japa();
                    break;
                case "6":
                    Exit("6");
                    break;
                default:
                    WriteLine("Invalid selection made, Chose the right option");
                    break;
            }
        }

        public static bool Exit(string num)
        {
            return string.Equals(num, "6", StringComparison.OrdinalIgnoreCase);
        }
    }   
}
