//Eh importante ressaltar que objetos vao comparar por referencia, logo se nao tiver um Equals
//e HashCode nao irao comparar o conteudo. Ja os Structs comparam nativamente os conteudos
using Entities;

namespace Conjuntos
{
    class Program
    {
        static public void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            Point p = new Point(3, 4);

            Console.WriteLine(a.Contains(prod));
            Console.WriteLine(b.Contains(p));
        }
    }
}