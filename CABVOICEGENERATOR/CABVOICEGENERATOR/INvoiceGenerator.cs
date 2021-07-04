using System;
using System.Collections.Generic;
using System.Text;

namespace CABVOICEGENERATOR
{
    public class INvoiceGenerator
    {
        Ridetype rideType;
        double price_per_km = 0;
        int price_per_min = 0;
        double min_fare = 0;
        public INvoiceGenerator(Ridetype.Riding type)
        {
            try
            {
                if (type == Ridetype.Riding.Normal)
                {
                    price_per_km = 10;
                    price_per_min = 1;
                    min_fare = 5;
                }
                if (type == Ridetype.Riding.Premium)
                {
                    price_per_km = 15;
                    price_per_min = 2;
                    min_fare = 20;
                }
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.InvalidRide, message: "Invalid Ride type");
            }
        }

        internal double Calculatefare(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public double CalculateFare(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance * price_per_km + time * price_per_min;
            }
            catch (CabInvoiceException)
            {
                if (rideType.Equals(null))
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.EmptyRide, "NO SUCH RIDE TYPE");
                }
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Distance, "NO SUCH distance");
                }
                if (time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.InvalidTime, "NO SUCH time");
                }
            }
            return Math.Max(totalFare, min_fare);
        }
    }
}
    

