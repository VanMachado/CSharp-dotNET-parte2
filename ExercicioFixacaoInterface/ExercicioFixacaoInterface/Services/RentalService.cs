using ExercicioFixacaoInterface.Entities;

namespace ExercicioFixacaoInterface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }    
        
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicpayments;
            if(duration.TotalHours <= 12)
            {
                basicpayments = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else
            {
                basicpayments = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = BrazilTaxService.Tax(basicpayments);

            carRental.Invoice = new Invoice(basicpayments, tax);
        }
    }
}
