using Entities;

namespace Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T: IComparable
        {
             if (list == null)
            {
                throw new ArgumentNullException("This list cannot be empty!");
            }

            T max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                //Aqui ele compara com ">0" pois o metodo retorna um inteiro no fim da comparacao
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
