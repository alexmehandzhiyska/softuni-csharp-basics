int nylonQty = int.Parse(Console.ReadLine());
int paintQty = int.Parse(Console.ReadLine());
int thinnerQty = int.Parse(Console.ReadLine());
int hoursOfWork = int.Parse(Console.ReadLine());

double totalPaintQty = paintQty * 1.1;
double totalNylonQty = nylonQty + 2;

double materialsPrice = totalNylonQty * 1.5 + totalPaintQty * 14.5 + thinnerQty * 5 + 0.4;
double workersPrice = hoursOfWork * (0.3 * materialsPrice);

double totalPrice = materialsPrice + workersPrice;

Console.WriteLine(totalPrice);
