using System.Globalization;

namespace Conjuntos
{
    class Program
    {
        static public void Main(string[] args)
        {
            string path = @"D:\workspace\C# e dotNet\votacao.txt";
            Dictionary<string, int> canditados = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] campos = sr.ReadLine().Split(',');
                        string nome = campos[0];
                        int votos = int.Parse(campos[1]);

                        if (canditados.ContainsKey(nome))
                        {
                            canditados[nome] += votos;
                        }
                        else
                        {
                            canditados[nome] = votos;
                        }                        
                    }

                    foreach (var lista in canditados)
                    {
                        Console.WriteLine(lista.Key + ": " + lista.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}