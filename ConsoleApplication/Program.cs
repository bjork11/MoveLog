using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while loop för main menyn
            Menu menu = new Menu();
            do
            {
                // Gör en instans av meny-klassen, tillkallar userinput som convertas till enum och skickas in i mainmenun.
                Menu.enumMainMenu choice = menu.GetUserInputMainMenuSwitch();

                if (choice == Menu.enumMainMenu.quit)
                {
                    return;
                }
                else
                {
                    menu.MainMenu(choice);
                }

            } while (true);
        }
    }
}
