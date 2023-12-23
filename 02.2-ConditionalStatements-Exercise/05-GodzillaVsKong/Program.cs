using System.Globalization;

double budget = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int actorCount = int.Parse(Console.ReadLine());
double singleOutfitPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double decorPrice = 0.1 * budget;
double totalOutfitPrice = singleOutfitPrice * actorCount;

if (actorCount > 150)
    totalOutfitPrice *= 0.9;

double totalPrice = decorPrice + totalOutfitPrice;

if (budget >= totalPrice)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {(budget - totalPrice):f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(totalPrice - budget):f2} leva more.");
}