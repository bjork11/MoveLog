using System;

namespace ClassLibrary
{
    abstract class Sport
    {
        protected string type;
        public virtual double PacePerDistance(double distanceInMeters, double timeInSeconds)
        {
            double distanceInKm = (distanceInMeters / 1000);
            double timeInMinutes = (timeInSeconds / 60);
            double minutesPerKm = (timeInMinutes / distanceInKm);

            return minutesPerKm;
        }
    }

    class Walking : Sport
    {
        public Walking()
        {
            this.type = "Walking";
        }
    }

    class Running : Sport
    {
        public Running()
        {
            this.type = "Running";
        }
    }

    class Biking : Sport
    {
        public Biking()
        {
            this.type = "Biking";
        }
    }

}
