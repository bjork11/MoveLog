using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    
    abstract class Sport
    {
        //static public bool walkingGoal;
        protected List<string> completedWorkouts = new List<string>();
        protected string type;
        public virtual string PacePerDistance(double distanceInMeters, double timeInSeconds)
        {
            double distanceInKm = (distanceInMeters / 1000);
            double secondsPerKm = (timeInSeconds / distanceInKm);

            TimeSpan t = TimeSpan.FromSeconds(secondsPerKm);
            return t.ToString();
        }

        public abstract void AddWorkout(double distanceInMeters, double timeInSeconds);

    }

    class Walking : Sport
    {
        public Walking()
        {
            this.type = "Walking";
        }

/*         public string GetType()
        {
            walkingGoal = true;
            return this.type;
        } */

        public override void AddWorkout(double distanceInMeters, double timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters/1000}km. Time: {timeInSeconds/60}min. Min Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");

            //if(walkingGoal)
            {

            }
        }
    }

    class Running : Sport
    {
        public Running()
        {
            this.type = "Running";
        }
        public override void AddWorkout(double distanceInMeters, double timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters/1000}km. Time: {timeInSeconds/60}min. Min Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");
        }
    }

    class Biking : Sport
    {
        public Biking()
        {
            this.type = "Biking";
        }

        public override void AddWorkout(double distanceInMeters, double timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters/1000}km. Time: {timeInSeconds/60}min. Min Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");
        }
    }

}
