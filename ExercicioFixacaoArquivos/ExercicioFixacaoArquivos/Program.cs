using ExercicioFixacaoArquivos.Entities;
using System.Globalization;

string sourcePath = @"D:\workspace\myfolder\Produtos1.csv";

try
{
    string[] lines = File.ReadAllLines(sourcePath);
    
    string sourceFolderPath = Path.GetDirectoryName(sourcePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePatth = targetFolderPath + @"\sumary.csv";

    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePatth))
    {
        foreach (string line in lines)
        {
            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(fields[2]);

            Products prod = new Products(name, price, quantity);

            sw.WriteLine(prod.Name + ", " + prod.Total().
                ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred! " + e.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}