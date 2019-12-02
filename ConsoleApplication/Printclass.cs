using System;
using ClassLibrary;

namespace ConsoleApplication
{
    class Printclass
    {
        public static void PrintCompletedWorkouts()
        {
            foreach (var workouts in Sport.completedWorkouts)
            {
                Console.WriteLine(workouts);
            }
            Console.ReadLine();

            if (Sport.completedWorkouts.Count == 0)
            {
                Console.WriteLine("You havn't registered any workouts yet! :(");
            }

        }
        public static void PrintCompletedGoals()
        {
            int i = 0;
            Console.WriteLine("Goals completed:");

            foreach (var goal in Goals.completedGoals)
            {
                i++;
                Console.WriteLine($"{i}: {goal.ToString()}");
            }

            Console.WriteLine();
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

            if(Goals.goalsInProgress.Count == 0)
            {
                Console.WriteLine("Nothing to see here.. :(\nSet a goal and get your fat body moving!");
            }

            Console.ReadLine();
        }
    }
}