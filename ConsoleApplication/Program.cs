using System;
using System.Collections.Generic;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            // joel som testar sin kod så att den fungerar. låt stå!

             
            Menu myMenu = new Menu();

            //convertar coice från enum till int och ber användaren skriva in ett nummer för enum menun!
              Menu.enumMenuChoice Choice =myMenu.GetUserInputForSwitch();
              myMenu.MainMenu(Choice);

              /* 
            
            //  Menu.goalsMenu Choice1 = myMenu.GetInputFromUSer();
            //  myMenu.GoalsMenu(Choice1);

            Menu.completedworkoutsMenu Choice3 = myMenu.GettingUserInputworkouts();
            myMenu.CompletedWorkoutMenu(Choice3);

            */

        }
    }
}
