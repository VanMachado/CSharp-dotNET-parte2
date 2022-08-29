namespace ExercicioFixacaoArquivos.Entities
{
    internal class Products
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Products()
        {
        }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;    
        }

        public double Total()
        {
            return Price * Quantity;
        }        
    }
}
