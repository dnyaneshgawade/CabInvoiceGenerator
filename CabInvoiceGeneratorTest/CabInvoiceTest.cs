using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_WhenAnalyze_ShouldReturnFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 15;
            int time = 30;
            double fare = invoice.CalculateFare(distance, time);
            double expected = 180;
            Assert.AreEqual(expected, fare);
        }
    }
}