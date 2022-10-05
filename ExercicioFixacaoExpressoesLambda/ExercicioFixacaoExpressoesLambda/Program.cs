using Entities;
using System.Globalization;

namespace ExercicioFixacaoExpressoesLambda
{
    class Program
    {
        static void Print<T>(IEnumerable<T> obj)
        {
            foreach (T item in obj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            string path = @"D:\workspace\in.txt";
            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }

                    Console.Write("Enter salary: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine($"Email of people whose salary is more than {value}:");
                    IEnumerable<string> salaryAboveValue = list
                        .Where(x => x.Salary > value)
                        .OrderBy(p => p.Email)
                        .Select(y => y.Email);
                    Print(salaryAboveValue);
                                        
                    double sum = list
                        .Where(p => p.Name[0] == 'M')
                        .Sum(x => x.Salary);
                    Console.Write($"Sum of salary of people whose name starts with 'M': {sum}");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}