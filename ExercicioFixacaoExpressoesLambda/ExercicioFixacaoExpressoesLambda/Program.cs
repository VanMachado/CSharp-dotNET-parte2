using Entities;

List<Products> products = new List<Products>();

products.Add(new Products(900.00, "TV"));
products.Add(new Products(1200.00, "Notebook"));
products.Add(new Products(450.00, "Tablet"));


//Pode ser feito assim, ou simplesmente declarando a funcao lambada no argumento
//Comparison<Products> comp = (p1, p2) => p1.Name.ToUpper().
//    CompareTo(p2.Name.ToUpper());

products.Sort((p1, p2) => p1.Name.ToUpper().
    CompareTo(p2.Name.ToUpper()));

foreach (Products p in products)
{
    Console.WriteLine(p);
}