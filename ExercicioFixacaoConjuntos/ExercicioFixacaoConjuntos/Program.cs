namespace Conjuntos
{
    class Program
    {
        static public void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //PrintCollector<int>(a);

            //Uniao
            SortedSet<int> c = new SortedSet<int> (a);
            Console.Write("Uniao: [ ");
            c.UnionWith(b);
            PrintCollector<int>(c);
            Console.Write("]");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            
            //Intersecao            
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Intersecao: [ ");
            PrintCollector(d);
            Console.Write("]");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");

            //Diferenca
            SortedSet<int> e = new SortedSet<int> (a);
            e.ExceptWith(b);
            Console.Write("Difrenca: [ ");
            PrintCollector(e);
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintCollector<T>(IEnumerable<T> collection) where T : IComparable
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }            
        }
    }
}