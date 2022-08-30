using Entities;
using Services;

namespace Services
{
    internal class PaypalService : IOnlinePaymentsService
    {
        private const double FeePercentagem = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interst(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {                       
            return amount * FeePercentagem;
        }
    }
}
