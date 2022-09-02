namespace ExercicioFixacaoConjuntos.Entities
{
    internal class PrintService
    {
        public List<int> Values { get; set; } = new List<int>();

        public void AddValue(int value)
        {
            for (int i = 0; i < value; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                Values.Add(valores);
            }
        }

        public int First()
        {
            return Values.First();
        }

        public void Print()
        {
            Console.Write("[ ");
            Values.Append(0);
            foreach (int value in Values)
            {
                Console.Write(value + " ");
            }
            Console.Write("]");
        }
    }
}
