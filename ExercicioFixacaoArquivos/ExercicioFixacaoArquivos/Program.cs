string sourcePath = @"D:\workspace\file1.txt";
string targetPath = @"D:\workspace\file2.txt";

try
{
    string[] lista = File.ReadAllLines(sourcePath);

    using (StreamWriter sr = File.AppendText(targetPath))
    {
        foreach(string line in lista)
        {
            sr.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred! " + e.Message);
}