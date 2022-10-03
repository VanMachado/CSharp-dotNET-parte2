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

            List<string> result = list.Select(UpdateName).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }        
        //O Func é um tipo de delegate que recebe um objeto do Tipo T como argumento
        //e retorna um valor, assim como o Action, ele pode ter 0 ou mais argumentos
        static string UpdateName(Product p)
        {
            return p.Name.ToUpper();            
        }
    }
}