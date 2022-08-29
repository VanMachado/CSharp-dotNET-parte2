string path = @"D:\workspace\file1.txt";

try
{
    Console.WriteLine("DirectorySepareteChar: " + Path.DirectorySeparatorChar);
    Console.WriteLine(Path.PathSeparator);
    Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
    Console.WriteLine("GetFileName: " + Path.GetFileName(path));
    Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
    Console.WriteLine("GetExtension: " + Path.GetExtension(path));
    Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
    Console.WriteLine("GetTempPath: " + Path.GetTempPath());
}
catch (IOException e)
{
    Console.WriteLine("An error occurred! " + e.Message);
}