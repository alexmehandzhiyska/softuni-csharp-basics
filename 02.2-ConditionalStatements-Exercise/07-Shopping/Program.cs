using System.Globalization;

double budget = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int graphicCardCount = int.Parse(Console.ReadLine());
int processorCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());

double graphicCardPrice = graphicCardCount * 250;
double processorPrice = processorCount * (0.35 * graphicCardPrice);
double ramPrice = ramCount * (0.1 * graphicCardPrice);

double totalPrice = graphicCardPrice + processorPrice + ramPrice;

if (graphicCardCount > processorCount)
    totalPrice *= 0.85;

if (budget >= totalPrice)
    Console.WriteLine($"You have {(budget - totalPrice):f2} leva left!");
else
    Console.WriteLine($"Not enough money! You need {(totalPrice - budget):f2} leva more!");