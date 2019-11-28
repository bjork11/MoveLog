using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public abstract class Sport
    {
        //När AddWorkout körs läggs träningspasset till i listan completedWorkouts
        public static List<string> completedWorkouts = new List<string>();
        protected string type;
        //Metod för att räkna ut hur lång tid varje kilometer tagit i genomsnitt.
        public virtual string PacePerDistance(double distanceInMeters, double timeInSeconds)
        {
            double distanceInKm = (distanceInMeters / 1000);
            double secondsPerKm = (timeInSeconds / distanceInKm);
            secondsPerKm = Math.Round(secondsPerKm);

            TimeSpan t = TimeSpan.FromSeconds(secondsPerKm);

            return t.ToString();
        }

        //Lägger till träningspass där avnändaren får mata in distans och tid på träningspasset. 
        //Kollar sedan om något mål av samma typ finns och uppdaterar det.
        //Och därefter flyttar den målet från listan "goalsinProgress" till listan "goalsCompleted"
        public void AddWorkout(int distanceInMeters, int timeInSeconds)
        {
            completedWorkouts.Add($"Workout: {type}. Distance: {distanceInMeters / 1000}km. Time: {timeInSeconds / 60}min. Time Per KM: {PacePerDistance(distanceInMeters, timeInSeconds)}");

            AddProgressToGoal(timeInSeconds, distanceInMeters);

            Goals.TransferIfCompleted();
        }

        //Lägger till träningspassets tid/distans till respektive mål om ett sådant finns.
        //Kollar först typen av "goal". (distance/time)
        //Därefter kollar den typen av "Sport". Annars hade varje Distancegoal uppdaterats oavsett om det är walking/biking/running som utförs.
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
