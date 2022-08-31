namespace Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] csv = csvEmployee.Split(',');
            Name = csv[0];
            Salary = double.Parse(csv[1]);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Objeto nao é trabalhador");
            }
            Employee other = (Employee)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
