string sourcePath = @"D:\workspace\file1.txt";

try
{
    using (StreamReader sr = File.OpenText(sourcePath))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred! " + e.Message);
}