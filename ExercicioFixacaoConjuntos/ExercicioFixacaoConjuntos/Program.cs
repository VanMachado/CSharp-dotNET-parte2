using Entities;
using System.Globalization;

namespace Conjuntos
{
    class Program
    {
        static public void Main(string[] args)
        {
            string path = @"D:\workspace\in.txt";
            HashSet<Client> set = new HashSet<Client>();

            try
            {               
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(' ');
                        string name = fields[0];
                        //Para ler a data no formato ISO 8601 precisa usar o ParseExact e o documento deve
                        //estar no formato da mascara abaixo
                        DateTime log = DateTime.ParseExact(fields[1],
                            "yyyyMMddTHH:mm:ss", CultureInfo.InvariantCulture);

                        set.Add(new Client(name, log));
                    }

                    Console.WriteLine($"Total users: {set.Count}");
                    Console.WriteLine("-------------------");
                    foreach(Client client in set)
                    {
                        Console.WriteLine(client);
                    }
                }                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}