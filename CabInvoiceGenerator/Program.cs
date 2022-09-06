using CabInvoiceGenerator;
using InvoiceGenerator;
using System;

namespace CabInvoiceGenrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator \n ");
            Invoice_Generator invoiceGenerator = new Invoice_Generator(RideType.Normal);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");

            Ride[] rides = { new Ride(2.0, 5), new Ride(1.0, 1) };
            invoiceGenerator.AddRides("name", rides);

            object value = invoiceGenerator.GetInvoiceSummary("name");
        }
    }
}