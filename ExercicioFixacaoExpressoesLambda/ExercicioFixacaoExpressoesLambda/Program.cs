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
            string[] lines = File.ReadAllLines(path);
            List<Product> list = new List<Product>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));
                    }
                }

                double average = list.Average(x => x.Price);
                var minOrd = list
                    .Where(x => x.Price < average)                    
                    .OrderByDescending(p => p.Name)
                    .Select(y => y.Name);
                Console.WriteLine("Average price: $" + average.ToString("F2"));
                Print(minOrd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}