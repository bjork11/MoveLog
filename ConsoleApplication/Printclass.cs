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
    }
}