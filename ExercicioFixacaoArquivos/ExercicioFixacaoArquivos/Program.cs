string path = @"D:\workspace\myfolder";

try
{
    IEnumerable<string> folder = Directory.
        EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine("FOLDERS:");
    foreach(string folderName in folder)
    {
        Console.WriteLine(folderName);
    }

    IEnumerable<string> files = Directory.
        EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine();

    Console.WriteLine("FILES:");
    foreach (string folderName in files)
    {
        Console.WriteLine(folderName);
    }

    Console.WriteLine();

    Directory.CreateDirectory(path + "\\newFolder");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred! " + e.Message);
}