string sourcePath = @"D:\workspace\file1.txt";
string targetpath = @"D:\workspace\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetpath);

    string[] lista = File.ReadAllLines(sourcePath);

    foreach(string line in lista)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occured! " + e.Message);
}