using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    abstract class Goals
    {
        protected bool goalCompleted;
        protected string type;
        public static List<Goals> goalsInProgress = new List<Goals>();
        private List<Goals> completedGoals = new List<Goals>();
        private List<Goals> notCompletedGoals = new List<Goals>();

        //Listan används tillfälligt för att ta bort alla avklarade mål från goalsInProgress. Detta för att slippa redigera listan medan vi går igenom den.
        public void TransferIfCompleted()
        {
            foreach (Goals goal in goalsInProgress)
            {
                //goal.GetType() == typeof(DistanceGoal)
                
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
            notCompletedGoals.Clear();
        }
        public virtual bool GoalAchieved()
        {
            return false;
        }

        public void RemoveGoal()
        {

        }

        public abstract void AddProgress(int progress);
    }

    class DistanceGoal : Goals
    {
        public static List<DistanceGoal> distanceGoals = new List<DistanceGoal>();
        private int meterTowardsGoal;
        public int _meterTowardsGoal { get; set; }
        private int goalInMeter;
        public DistanceGoal(int inputMeter)
        {
            goalCompleted = false;
            meterTowardsGoal = 0;
            goalInMeter = inputMeter;
        }

        public override void AddProgress(int meter)
        {
            meterTowardsGoal += meter;
        }

        public override bool GoalAchieved()
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
        public void AddDistanceGoal(int input)
        {
            distanceGoals.Add(new DistanceGoal(input));
        }
    }
    class TimeGoal : Goals
    {
        public static List<TimeGoal> timeGoals = new List<TimeGoal>();
        private int secondsTowardsGoal;
        public int _secondsTowardsGoal { get; set; }
        private int goalInSeconds;
        public TimeGoal(int inputSecond)
        {
            goalCompleted = false;
            secondsTowardsGoal = 0;
            goalInSeconds = inputSecond;
        }

         public override void AddProgress(int seconds)
        {
            secondsTowardsGoal += seconds;
        }

        public override bool GoalAchieved()
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
        public void AddTimeGoal(int input)
        {
            timeGoals.Add(new TimeGoal(input));
        }
    }
}