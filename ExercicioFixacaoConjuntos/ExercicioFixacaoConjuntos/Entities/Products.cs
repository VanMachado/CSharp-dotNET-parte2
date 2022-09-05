namespace Entities
{
    internal class Products : IComparable
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Products(string name, double value)
        {
            Name = name;
            Value = value;
        }

        //Nessa sobrecarga do "CompareTo" que defino o que vou comparar, no caso o valor,
        //mas poderia ser o nome, por exemplo.
        public int CompareTo(object? obj)
        {
            if (!(obj is Products))
            {
                throw new ArgumentException("Invalid type!");
            }

            Products other = (Products)obj;

            return Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return Name + ", " + Value;
        }
    }
}
