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
        private List<Goals> notCompletedGoals = new List<Goals>();


        public void Transfer()
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
        private int meterTowardsGoal;
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
        private int secondTowardsGoal;
        private int goalInSecond;
        public TimeGoal(int inputSecond)
        {
            this.type = "Time";
            goalCompleted = false;
            secondTowardsGoal = 0;
            goalInSecond = inputSecond;
        }
        public override bool GoalAchieved()
        {
            if (secondTowardsGoal >= goalInSecond)
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