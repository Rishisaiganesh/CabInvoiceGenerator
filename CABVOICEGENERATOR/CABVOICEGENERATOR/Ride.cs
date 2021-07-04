using System;
using System.Collections.Generic;
using System.Text;

namespace CABVOICEGENERATOR
{
   public class Ride
    {
        public double Distance;
        public int Time;
        public Ride(double Distance, int Time)
        {
            this.Distance = Distance;
            this.Time = Time;
        }
    }
}
