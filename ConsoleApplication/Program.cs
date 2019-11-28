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
            bool doWileLoopForMainMenu = true;

            do
            {
                // Gör en instans av memyn klassen, tillkallar userinput som convertas till enum och skickas in i mainmenun.
                Menu menu = new Menu();
                Menu.enumMainMenu choice = menu.GetUserInputForSwitch();
        
                if (choice == Menu.enumMainMenu.quit)
                {
                    doWileLoopForMainMenu = false;
                }
                else
                {
                    menu.MainMenu(choice);
                }

            } while (doWileLoopForMainMenu == true);
        }
    }
}
