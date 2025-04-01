using Atividade01.Entities;
using System.Globalization;



Console.Write("Enter product name: ");
string name = Console.ReadLine();

Console.Write("Enter product price: ");
double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter product quantity: ");
int quantity = int.Parse(Console.ReadLine());

Product p = new Product(name, price, quantity, 0);
p.AddStock();

Console.WriteLine(p);
p.StockTotal();

Console.Write("Enter the products to be removed from stock: ");
int remove = int.Parse(Console.ReadLine());
p.RemoveStock(remove);

Console.WriteLine(p);


p.StockTotal();