using System;

namespace CABVOICEGENERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cab Service");
            INvoiceGenerator voice = new INvoiceGenerator(Ridetype.Riding.Normal);
            double Fare = voice.Calculatefare(10, 20);
            Console.WriteLine("Total fare is :" + Fare);
        }
    }
}
