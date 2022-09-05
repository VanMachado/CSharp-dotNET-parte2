using Entities;
using Services;

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

List<Products> lista = new List<Products>();

for (int i = 0; i < n; i++)
{
    string[] fields = Console.ReadLine().Split(',');
    string name = fields[0];
    double value = double.Parse(fields[1]);
    
    lista.Add(new Products(name, value));
}

Console.WriteLine("MAX:");

CalculationService service = new CalculationService();

Console.WriteLine(service.Max(lista));