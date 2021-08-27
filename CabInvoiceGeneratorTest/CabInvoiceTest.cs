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

        [Test]
        public void GivenMultipleRides_WhenAnalyze_ShouldReturnTotalFaresOfMultipleRides()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(12, 15), new Ride(10, 20) };

            InvoiceSummary summary = new InvoiceSummary(2, 255);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.totalFare, expected.totalFare);
        }

        [Test]
        public void GivenMultipleRides_WhenAnalyze_ShouldReturnAverageFaresOfMultipleRides()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(12, 15), new Ride(10, 20) };

            InvoiceSummary summary = new InvoiceSummary(2, 255);
            InvoiceSummary expected = invoice.CalculateFare(rides);
            Assert.AreEqual(summary.averageFare, expected.averageFare);
        }
    }
}