using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    abstract class Goals
    {
        protected string type;
        private List<Goals> completedGoals = new List<Goals>();
        private List<Goals> goalsInProgress = new List<Goals>();

        public void AddTimeGoal()
        {
            goalsInProgress.Add(new TimeGoal());
        }

        public void AddDistanceGoal()
        {
            goalsInProgress.Add(new DistanceGoal());
        }
        public void RemoveGoal()
        {

        }
    }

    class DistanceGoal : Goals
    {
        public DistanceGoal()
        {
            this.type = "Distance";
        }
    }
    class TimeGoal : Goals
    {
        public TimeGoal()
        {
            this.type = "Time";
        }
    }
}