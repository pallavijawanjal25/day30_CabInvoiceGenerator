using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    internal class Invoice_Generator
    {
        private RideType normal;

        public Invoice_Generator(RideType normal)
        {
            this.normal = normal;
        }

        internal double CalculateFare(double distance, int time)
        {
            throw new NotImplementedException();
        }
    }
}