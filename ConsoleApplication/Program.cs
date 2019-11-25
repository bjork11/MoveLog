using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        public static void PrintCompletedWorkouts()
        {
            foreach (var workouts in Sport.completedWorkouts)
            {
                Console.WriteLine(workouts);
            }
        }
        static void Main(string[] args)
        {
            Running myWorkout = new Running();

            myWorkout.AddWorkout(15000, 10000);
            
            PrintCompletedWorkouts();
        }  
    }
}
