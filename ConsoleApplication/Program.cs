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
            // Gör en instans av memyn klassen, tillkallar userinput som convertas till enum och skickas in i mainmenun.
            Menu menu = new Menu();

            int sdfsdf = menu.IntUserInputTryCatch();
            Console.WriteLine(sdfsdf);
            //Menu.enumMainMenu choice = menu.GetUserInputForSwitch();
            //menu.MainMenu(choice);

        }  
    }
}
