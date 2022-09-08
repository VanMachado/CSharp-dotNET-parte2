namespace Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Invalid type");
            }
            
            Product other = obj as Product;
            if(Name.Equals(other.Name) && Price.Equals(other.Price))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
    }
}
