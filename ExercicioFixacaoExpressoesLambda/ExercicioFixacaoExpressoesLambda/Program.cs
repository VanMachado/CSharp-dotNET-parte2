using Entities;
using System.Linq;

namespace ExercicioFixacaoExpressoesLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> colection)
        {
            Console.WriteLine(message);

            foreach (T obj in colection)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("===================================");
        }

        public static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>() {
                new Product(1, "Computer", 900.00, c2),
                new Product(2, "Hammer", 90.0, c1),
                new Product(3, "TV", 1700.0, c3),
                new Product(4, "Notebook", 1300.0, c2),
                new Product(5, "Saw", 80.0, c1),
                new Product(6, "Tablet", 700.0, c2),
                new Product(7, "Camera", 700.0, c3),
                new Product(8, "Printer", 350.0, c3),
                new Product(9, "MacBook", 1800.0, c2),
                new Product(10, "Sound Bar", 700.0, c3),
                new Product(11, "Level", 70.0, c1)
            };

            //Tier 1 and Price < 900
            IEnumerable<Product> result1 = products
                .Where(x => x.Price < 900.00 && x.Category.Tier == 1);
            //Names of products from Tools
            List<string> result2 = products
                .Where(x => x.Category.Name == "Tools")
                .Select(x => x.Name)
                .ToList();
            //Products start with 'C'
            var result3 = products
                .Where(x => x.Name[0] == 'c' || x.Name[0] == 'C')
                .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            //Tier 1, cheap to more expensive
            IEnumerable<Product> result4 = products.
                Where(x => x.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name);
            //Tier 1, Order by price then by name skip 2 and take 4
            IEnumerable<Product> result5 = result4.Skip(2).Take(4);
            //First test
            var result6 = products.First();
            //FirstorDefault test para evitar runtime exceptions
            var result7 = products
                .Where(x => x.Price > 2000.00)
                .FirstOrDefault();
            //SingleOrDefault test
            var result8 = products
                .Where(x => x.Id == 3)
                .SingleOrDefault();
            //Max price
            double result9 = products.Max(p => p.Price);
            //Min price
            double result10 = products.Min(p => p.Price);
            //Category 1 sum price
            double result11 = products.Where(x => x.Category.Id == 1).Sum(p => p.Price);
            //Category 1 average price
            double result12 = products.Where(x => x.Category.Id == 1).Average(p => p.Price);
            //Category 5 average price
            double result13 = products.Where(x => x.Category.Id == 5)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();
            //Usando o aggregate. O papel do '0.0' eh atribuir um valor padrao em caso de runtime exception
            var result14 = products
                .Where(x => x.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0, (x, y) => x + y);
            //Usando o GroupBy
            var result15 = products
                .GroupBy(p => p.Category);

            Print("Tier 1 and Price < 900", result1);
            Print("Names of products from Tools", result2);
            Print("Products start with 'C' and Anonymous Object", result3);
            Print("Tier 1, Order by price then by name", result4);
            Print("Tier 1, Order by price then by name skip 2 and take 4", result5);
            Console.WriteLine("First test: " + result6);
            Console.WriteLine("===================================");
            Console.WriteLine("FirstOrDefault test: " + result7);
            Console.WriteLine("===================================");
            Console.WriteLine("SingleOrDefault test: " + result8);
            Console.WriteLine("===================================");
            Console.WriteLine("Max price: " + result9);
            Console.WriteLine("===================================");
            Console.WriteLine("Min price: " + result10);
            Console.WriteLine("===================================");
            Console.WriteLine("Category 1 sum price: " + result11);
            Console.WriteLine("===================================");
            Console.WriteLine("Category 1 average price: " + result12);
            Console.WriteLine("===================================");
            Console.WriteLine("Category 5 average price: " + result13);
            Console.WriteLine("===================================");
            Console.WriteLine("Category 1 aggregate sum: " + result14);
            Console.WriteLine("===================================");
            Console.WriteLine("Usando o GroupBy: ");
           
            foreach(IGrouping<Category, Product> gruop in result15)
            {
                Console.WriteLine("Category " + gruop.Key.Name + ": ");
                foreach(Product x in gruop)
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("===================================");
            }
        }
    }
}