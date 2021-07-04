using System;
using System.Collections.Generic;
using System.Text;

namespace CABVOICEGENERATOR
{
   public class CabInvoiceException
    {
        public enum ExceptionType
        {
            InvalidDistance,
            InvalidUserID,
            InvalidRide,
            EmptyRide,
            InvalidTime,
            Invalid_Distance
        }
        ExceptionType Type;
        public CabInvoiceException(ExceptionType Type,string message)
        {
            Console.WriteLine("Exception What we get" + Type + message);
        }
    }
}
