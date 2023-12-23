int penPackets = int.Parse(Console.ReadLine());
int markerPackets = int.Parse(Console.ReadLine());
int detergentQty = int.Parse(Console.ReadLine());
int discountPercent = int.Parse(Console.ReadLine());

double price = penPackets * 5.8 + markerPackets * 7.2 + detergentQty * 1.2;
double discountedPrice = price - ((double)discountPercent / 100 * price);

Console.WriteLine(discountedPrice);