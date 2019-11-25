using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    abstract class Goals
    {
        protected bool goalCompleted;
        protected string type;
        private List<Goals> completedGoals = new List<Goals>();
        protected List<Goals> goalsInProgress = new List<Goals>();

        //Listan används tillfälligt för att ta bort alla avklarade mål från goalsInProgress. Detta för att slippa redigera listan medan vi går igenom den.
        private List<Goals> notCompletedGoals = new List<Goals>();

        public void TransferCompletedGoals()
        {
            foreach (Goals goal in goalsInProgress)
            {
                if (GoalAchieved())
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
    }

    class DistanceGoal : Goals
    {
        public static List<DistanceGoal> distanceGoals = new List<DistanceGoal>();
        private int meterTowardsGoal;
        public int _meterTowardsGoal { get; set; }
        private int goalInMeter;
        public DistanceGoal(int inputMeter)
        {
            this.type = "Distance";
            goalCompleted = false;
            meterTowardsGoal = 0;
            goalInMeter = inputMeter;
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
            goalsInProgress.Add(new DistanceGoal(input));
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
            this.type = "Time";
            goalCompleted = false;
            secondsTowardsGoal = 0;
            goalInSeconds = inputSecond;
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
            goalsInProgress.Add(new TimeGoal(input));
        }
    }
}