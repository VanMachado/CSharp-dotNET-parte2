namespace Services
{
    interface IOnlinePaymentsService
    {
        public double PaymentFee(double amount);

        public double Interst(double amount, int months);
    }
}
