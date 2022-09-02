//Dessa maneira, usando o Generics da maneira correta, atraves do <T> consigo deixar
//o programa mais flexivel, podendo receber qualquer tipo de dado.

namespace ExercicioFixacaoConjuntos.Entities
{
    internal class PrintService<T>
    {
        public List<T> Values { get; set; } = new List<T>();

        public void AddValue(T value)
        {
            Values.Add(value);
        }

        public T First()
        {
            return Values.First();
        }

        public void Print()
        {
            Console.Write("[ ");            
            foreach (T value in Values)
            {
                Console.Write(value + " ");
            }
            Console.Write("]");
        }
    }
}
