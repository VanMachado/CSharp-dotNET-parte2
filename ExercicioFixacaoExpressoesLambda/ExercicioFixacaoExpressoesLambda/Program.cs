using Entities;

List<Products> products = new List<Products>();

products.Add(new Products(900.00, "TV"));
products.Add(new Products(1200.00, "Notebook"));
products.Add(new Products(450.00, "Tablet"));

products.Sort(CompareProducts);

foreach(Products p in products)
{
    Console.WriteLine(p);
}

static int CompareProducts(Products p1, Products p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}