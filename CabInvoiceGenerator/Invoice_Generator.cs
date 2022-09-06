using CabInvoiceGenerator;

namespace CabInvoiceGenrator
{
    internal class Invoice_Generator
    {
        private RideType normal;

        public Invoice_Generator(RideType normal)
        {
            this.normal = normal;
        }

        internal void AddRides(string v, Ride[] rides)
        {
            throw new NotImplementedException();
        }

        internal double CalculateFare(double v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal object GetInvoiceSummary(string v)
        {
            throw new NotImplementedException();
        }
    }
}