using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public abstract class Goals
    {
        protected bool goalCompleted;
        //Typ av Sport målet är uppsatt för
        internal string sportType;
        //Målen som är pågående
        public static List<Goals> goalsInProgress = new List<Goals>();
        //Alla mål som är avklarade
        public static List<Goals> completedGoals = new List<Goals>();

        //Metod som körs i Sport.AddWorkout()-metoden för att flytta målet mellan listorna
        //goalsInProgress och completedGoals om målet är avklarat.
        internal static void TransferIfCompleted()
        {
            //Listan används tillfälligt för att ta bort alla avklarade mål från goalsInProgress. Detta för att slippa redigera listan medan vi går igenom den.
            List<Goals> notCompletedGoals = new List<Goals>();

            foreach (Goals goal in goalsInProgress)
            {
                if (goal.GoalAchieved())
                {
                    completedGoals.Add(goal);
                }
                else
                {
                    notCompletedGoals.Add(goal);
                } 
            }

            goalsInProgress = notCompletedGoals; 
        }

        //Returnerar false/true om målet är uppnått. Olika override beroende på typen av mål.
        protected abstract bool GoalAchieved();

        //Tar bort specifikt mål utifrån plats i listan över goalsInProgress
        public static void RemoveGoal(int input)
        {
            goalsInProgress.RemoveAt(input);
        }

        internal abstract void AddProgress(int progress);
    }

    public class DistanceGoal : Goals
    {
        //För att hålla koll på hur nära målet man kommit
        internal int meterTowardsGoal; 
        //Hur långt man sätter upp att målet ska vara i meter
        private int goalInMeter;
        //Konstruktor som tar in hur långt målet ska vara och vilket sport målet ska vara för.
        private DistanceGoal(int inputMeter, string typeOfWorkout)
        {
            sportType = typeOfWorkout;
            goalCompleted = false;
            meterTowardsGoal = 0;
            goalInMeter = inputMeter;
        }

        //ToString-override för att skriva ut hur nära ett mål är att bli avklarat. 
        public override string ToString()
        {
            return string.Format($"{sportType}: {meterTowardsGoal}/{goalInMeter} meters");
        }

        //Lägger till träningspassets distans till meterTowardsGoal
        internal override void AddProgress(int meter)
        {
            meterTowardsGoal += meter;
        }

        //Ifall målet är uppnåt returnera true. För att veta när målet ska flyttas från en lista till en annan.
        protected override bool GoalAchieved()
        {
            if (meterTowardsGoal >= goalInMeter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Lägger till nytt DistanceGoal. Användaren får mata in längd och typ av Sport. 
        public static void AddDistanceGoal(int input, string type)
        {
            goalsInProgress.Add(new DistanceGoal(input, type));
        }
    }
    public class TimeGoal : Goals
    {
        private int secondsTowardsGoal;
        public int _secondsTowardsGoal { get; set; }

        //Hur länge man ska träna för att uppfylla målet i sekunder.
        private int goalInSeconds;
        private TimeGoal(int inputSecond, string typeOfWorkout)
        {
            sportType = typeOfWorkout;
            goalCompleted = false;
            secondsTowardsGoal = 0;
            goalInSeconds = inputSecond;
        }

        public override string ToString()
        {
            return string.Format($"{sportType}: {secondsTowardsGoal}/{goalInSeconds} seconds");
        }

        internal override void AddProgress(int seconds)
        {
            secondsTowardsGoal += seconds;
        }

        protected override bool GoalAchieved()
        {
            if (secondsTowardsGoal >= goalInSeconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void AddTimeGoal(int input, string type)
        {
            goalsInProgress.Add(new TimeGoal(input, type));
        }
    }
}