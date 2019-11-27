using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public abstract class Sport
    {
        //static public bool walkingGoal;
        public static List<string> completedWorkouts = new List<string>();
        //public List <string> _completedWorkouts {get;}

        protected string type;
        public virtual string PacePerDistance(int distanceInMeters, int timeInSeconds)
        {
            double distanceInKm = (distanceInMeters / 1000);
            double secondsPerKm = (timeInSeconds / distanceInKm);
            secondsPerKm = Math.Round(secondsPerKm);

            TimeSpan t = TimeSpan.FromSeconds(secondsPerKm);

            return t.ToString();
        }

        public void AddWorkout(int distanceInMeters, int timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters / 1000}km. Time: {timeInSeconds / 60}min. Time Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");

            AddProgressToGoal(timeInSeconds, distanceInMeters);

            Goals.TransferIfCompleted();
        }

        public void AddProgressToGoal(int timeInSeconds, int distanceInMeters)
        {
            {
                foreach (var goal in ClassLibrary.Goals.goalsInProgress)
                {
                    if (goal.GetType() == typeof(DistanceGoal))
                    {
                        if (type == goal.type)
                        {
                            goal.AddProgress(distanceInMeters);
                        }
                    }

                    if (goal.GetType() == typeof(TimeGoal))
                    {
                        if (type == goal.type)
                        {
                            goal.AddProgress(timeInSeconds);
                        }
                    }
                }
            }
        }
    }

    public class Walking : Sport
    {
        public Walking()
        {
            this.type = "Walking";
        }
    }

    public class Running : Sport
    {
        public Running()
        {
            this.type = "Running";
        }

    }

    public class Biking : Sport
    {
        public Biking()
        {
            this.type = "Biking";
        }

    }
}
