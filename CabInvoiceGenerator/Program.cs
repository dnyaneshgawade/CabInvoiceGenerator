using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome To The Cab Invoice Service!!!");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(13, 24);
            Console.WriteLine($"Fare : {fare}");
        }
    }
}
