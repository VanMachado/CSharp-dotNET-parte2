using Entities;

List<Products> products = new List<Products>();

products.Add(new Products(900.00, "TV"));
products.Add(new Products(1200.00, "Notebook"));
products.Add(new Products(450.00, "Tablet"));

products.Sort();

foreach(Products p in products)
{
    Console.WriteLine(p);
}