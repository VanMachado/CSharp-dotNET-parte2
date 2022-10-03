using Entities;

namespace ExercicioFixacaoExpressoesLambda
{   
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(UpdatePrice);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }        
        //O action é um tipo de delegate que recebe um objeto do Tipo T como argumento
        //e nao retorna nada e pode ser usardo em metodos que recebm um action como argumento
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.10;
        }
    }
}