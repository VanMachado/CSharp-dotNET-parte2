using System.Globalization;

namespace Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salaray)
        {
            Name = name;
            Email = email;
            Salary = salaray;
        }

        public override string ToString()
        {
            return Name + ", " + Email + ", " + Salary
                .ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
