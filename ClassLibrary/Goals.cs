using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public abstract class Goals
    {
        protected bool goalCompleted;
        public string type;
        public static List<Goals> goalsInProgress = new List<Goals>();
        public static List<Goals> completedGoals = new List<Goals>();

        //Listan används tillfälligt för att ta bort alla avklarade mål från goalsInProgress. Detta för att slippa redigera listan medan vi går igenom den.
        public static void TransferIfCompleted()
        {
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
        public virtual bool GoalAchieved()
        {
            return false;
        }

        public static void RemoveGoal(int input)
        {
            goalsInProgress.RemoveAt(input);
        }

        public abstract void AddProgress(int progress);

    }

    public class DistanceGoal : Goals
    {
        private int meterTowardsGoal;
        public int _meterTowardsGoal { get; set; }
        private int goalInMeter;
        public DistanceGoal(int inputMeter, string typeOfWorkout)
        {
            type = typeOfWorkout;
            goalCompleted = false;
            meterTowardsGoal = 0;
            goalInMeter = inputMeter;
        }

        public override string ToString()
        {
            return string.Format($"{type}: {meterTowardsGoal}/{goalInMeter} meter");
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
        public static void AddDistanceGoal(int input, string type)
        {
            goalsInProgress.Add(new DistanceGoal(input, type));
        }
    }
    public class TimeGoal : Goals
    {
        private int secondsTowardsGoal;
        public int _secondsTowardsGoal { get; set; }
        private int goalInSeconds;
        public TimeGoal(int inputSecond, string typeOfWorkout)
        {
            type = typeOfWorkout;
            goalCompleted = false;
            secondsTowardsGoal = 0;
            goalInSeconds = inputSecond;
        }

        public override string ToString()
        {
            return string.Format($"{type}: {secondsTowardsGoal}/{goalInSeconds} sekunder");
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
        public static void AddTimeGoal(int input, string type)
        {
            goalsInProgress.Add(new TimeGoal(input, type));
        }
    }
}