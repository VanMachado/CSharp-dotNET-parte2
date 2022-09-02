using ExercicioFixacaoConjuntos.Entities;

try
{
    Console.Write("How many values to insert? ");
    int n = int.Parse(Console.ReadLine());

    PrintService printer = new PrintService();

    printer.AddValue(n);

    Console.WriteLine();
    printer.Print();
    Console.WriteLine();
    Console.Write("First: ");
    Console.WriteLine(printer.First());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}