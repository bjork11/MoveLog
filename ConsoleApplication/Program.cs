using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        /* 
        public static void PrintCompletedWorkouts()
        {
            foreach (var workouts in Sport.completedWorkouts)
            {
                Console.WriteLine(workouts);
            }
        }
<<<<<<< HEAD

        public static void PrintCompletedGoals()
=======
        */
        static void Main(string[] args)
>>>>>>> b0b0df7cdd1341b3b8ed719becb201b9e5062746
        {
            int i = 0;
            Console.WriteLine("Goals completed:");

<<<<<<< HEAD
            foreach (var goal in Goals.completedGoals)
            {
                i++;
                Console.WriteLine($"{i}: {goal.ToString()}");
            }
        }

        public static void PrintGoalsInProgress()
        {
            int i = 0;
            Console.WriteLine("Goals in progress:");

            foreach (var goal in Goals.goalsInProgress)
            {
                i++;
                Console.WriteLine($"{i}: {goal.ToString()}");
            }
        }
        static void Main(string[] args)
        {
            Sport workout = new Running();
            ClassLibrary.DistanceGoal.AddDistanceGoal(10000, "Running");
            PrintGoalsInProgress();
            workout.AddWorkout(10000, 5000);
            PrintCompletedGoals();
            PrintCompletedWorkouts();
=======
            myWorkout.AddWorkout(15000, 10000);
            
           // PrintCompletedWorkouts();
            
           /*
           ---------------------------- joels cod för att testa skiten 
           Menu menu = new Menu();

           Menu.enumMenuChoice Choice =menu.GetUserInputForSwitch();     
           menu.MainMenu(Choice);

           */

           
        
>>>>>>> b0b0df7cdd1341b3b8ed719becb201b9e5062746
        }  


         

         

    }
}
