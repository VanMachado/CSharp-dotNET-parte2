using ExercicioFixacaoConjuntos.Entities;

try
{
    Console.Write("How many values to insert? ");
    int n = int.Parse(Console.ReadLine());

    //Ao instanciar a classe generica, eu defino qual tipo de dado eu vou receber sem perder a coesao do
    //programa e matendo o TypeSafety
    PrintService<string> printer = new PrintService<string>();

    for(int i = 0; i < n; i++)
    {
        string resp = Console.ReadLine();
        printer.AddValue(resp);
    }

    Console.WriteLine();
    printer.Print();
    Console.WriteLine();
    Console.Write("First: ");
    Console.WriteLine(printer.First());
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}