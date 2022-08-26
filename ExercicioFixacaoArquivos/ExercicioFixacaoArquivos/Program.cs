string sourcePath = @"D:\workspace\file1.txt";
string targetpath = @"D:\workspace\file2.txt";

//FileStream fs = null;
StreamReader sr = null;

try
{
    //fs = new FileStream(sourcePath, FileMode.Open); //pode ser instanciado assim tbm
    sr = File.OpenText(sourcePath);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }    
}
catch (Exception)
{

    throw;
}
finally
{
    if (sr != null)
        sr.Close();
    // (fs != null) fs.Close();
}