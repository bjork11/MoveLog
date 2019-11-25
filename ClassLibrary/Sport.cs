using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    
    abstract class Sport
    {
        //static public bool walkingGoal;
        protected List<string> completedWorkouts = new List<string>();
        protected string type;
        public virtual string PacePerDistance(int distanceInMeters, int timeInSeconds)
        {
            double distanceInKm = (distanceInMeters / 1000);
            double secondsPerKm = (timeInSeconds / distanceInKm);

            TimeSpan t = TimeSpan.FromSeconds(secondsPerKm);
            return t.ToString();
        }

        public abstract void AddWorkout(int distanceInMeters, int timeInSeconds);


        //Metoden AddProgressToTimeGoal. 
        public void AddProgressToTimeGoal(List <TimeGoal> timeGoals, int timeInSeconds)
        {
            foreach(var goals in timeGoals)
            {
                goals._secondsTowardsGoal += timeInSeconds;
            }
        }

        public void AddProgressToDistanceGoal(List <DistanceGoal> distanceGoals, int distanceInMeters)
        {
            foreach(var goals in distanceGoals)
            {
                goals._meterTowardsGoal += distanceInMeters;
            }
        }

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

        public override void AddWorkout(int distanceInMeters, int timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters/1000}km. Time: {timeInSeconds/60}min. Min Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");

            if(ClassLibrary.TimeGoal.timeGoals.Count > 0)
            {
                AddProgressToTimeGoal(ClassLibrary.TimeGoal.timeGoals, timeInSeconds);
            }

            if(ClassLibrary.DistanceGoal.distanceGoals.Count > 0)
            {
                AddProgressToDistanceGoal(ClassLibrary.DistanceGoal.distanceGoals, distanceInMeters);
            }
        }
    }

    class Running : Sport
    {
        public Running()
        {
            this.type = "Running";
        }
        public override void AddWorkout(int distanceInMeters, int timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters/1000}km. Time: {timeInSeconds/60}min. Min Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");

            if(ClassLibrary.TimeGoal.timeGoals.Count > 0)
            {
                AddProgressToTimeGoal(ClassLibrary.TimeGoal.timeGoals, timeInSeconds);
            }

            if(ClassLibrary.DistanceGoal.distanceGoals.Count > 0)
            {
                AddProgressToDistanceGoal(ClassLibrary.DistanceGoal.distanceGoals, distanceInMeters);
            }
        }
    }

    class Biking : Sport
    {
        public Biking()
        {
            this.type = "Biking";
        }

        public override void AddWorkout(int distanceInMeters, int timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters/1000}km. Time: {timeInSeconds/60}min. Min Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");

            if(ClassLibrary.TimeGoal.timeGoals.Count > 0)
            {
                AddProgressToTimeGoal(ClassLibrary.TimeGoal.timeGoals, timeInSeconds);
            }

            if(ClassLibrary.DistanceGoal.distanceGoals.Count > 0)
            {
                AddProgressToDistanceGoal(ClassLibrary.DistanceGoal.distanceGoals, distanceInMeters);
            }
        }
    }

}
