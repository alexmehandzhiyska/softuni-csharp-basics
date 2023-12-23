int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegMenus = int.Parse(Console.ReadLine());

double totalMenuPrice = chickenMenus * 10.35 + fishMenus * 12.4 + vegMenus * 8.15;
double dessertPrice = 0.2 * totalMenuPrice;

double totalPrice = totalMenuPrice + dessertPrice + 2.5;

Console.WriteLine(totalPrice);