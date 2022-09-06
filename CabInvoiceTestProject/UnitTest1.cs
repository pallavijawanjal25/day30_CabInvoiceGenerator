using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using CabInvoiceGenrator;
using InvoiceGenerator;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly object Invoice_Generator;
        Invoice_Generator invoiceGenertor = null;
        private InvoiceSummary summary;
        public readonly object Calculatefare;

        [TestMethod]
        public void GivenDistanceAndTimeShouldTotalFare()
        {
            invoiceGenertor = new Invoice_Generator(RideType.Normal);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenertor.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            InvoiceGenertor invoiceGenertor = new InvoiceGenertor(RideType.Normal);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            
            InvoiceSummary excpectedSummary = new(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary);
        }
    }
}