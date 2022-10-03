using Service;

namespace ExercicioFixacaoExpressoesLambda
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        public static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);            
        }
    }
}