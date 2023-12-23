using System.Globalization;

double tripPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int puzzleCount = int.Parse(Console.ReadLine());
int dollCount = int.Parse(Console.ReadLine());
int bearCount = int.Parse(Console.ReadLine());
int minionCount = int.Parse(Console.ReadLine());
int truckCount = int.Parse(Console.ReadLine());

double moneyEarned = (puzzleCount * 2.6) + (dollCount * 3) + (bearCount * 4.1) + (minionCount * 8.2) + (truckCount * 2);
int toyCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;

if (toyCount >= 50)
    moneyEarned *= 0.75;
    
moneyEarned *= 0.9;

if (moneyEarned >= tripPrice)
    Console.WriteLine($"Yes! {(moneyEarned - tripPrice):f2} lv left.");
else
    Console.WriteLine($"Not enough money! {(tripPrice - moneyEarned):f2} lv needed.");