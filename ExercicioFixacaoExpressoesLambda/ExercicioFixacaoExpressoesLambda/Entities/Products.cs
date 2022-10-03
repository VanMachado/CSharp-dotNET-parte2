using System.Globalization;

namespace Entities
{
    internal class Products : IComparable<Products>
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Products(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return Name + ", " + Price.
                ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Products other)
        {                        
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}
