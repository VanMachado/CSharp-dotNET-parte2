using Entities;

namespace TesteComparacao
{

    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D:\workspace\in.txt";
            string target = @"D:\workspace\in2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> employee = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        employee.Add(new Employee(sr.ReadLine()));
                    }

                    employee.Sort();

                    foreach (Employee str in employee)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}