namespace Entities
{
    internal class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installment { get; private set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;            
        }        

        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }
    }
}
