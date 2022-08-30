using Entities;

namespace Services
{
    internal class ContractService
    {
        private IOnlinePaymentsService _onlinePaymentsService;

        public ContractService(IOnlinePaymentsService onlinePaymentsService)
        {
            _onlinePaymentsService = onlinePaymentsService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicoQuota = contract.TotalValue / months;

            for (int i = 0; i < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i+1);
                double updateQuota = basicoQuota + _onlinePaymentsService.Interst(basicoQuota, i+1);
                double fullQuota = updateQuota + _onlinePaymentsService.PaymentFee(updateQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
