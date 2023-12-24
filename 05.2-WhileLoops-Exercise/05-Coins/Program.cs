using System.Globalization;

double change = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pennies = Math.Round(change * 100);
int coins = 0;

while (pennies > 0)
{
    if (pennies >= 200)
        pennies -= 200;
    else if (pennies >= 100)
        pennies -= 100;
    else if (pennies >= 50)
        pennies -= 50;
    else if (pennies >= 20)
        pennies -= 20;
    else if (pennies >= 10)
        pennies -= 10;
    else if (pennies >= 5)
        pennies -= 5;
    else if (pennies >= 2)
        pennies -= 2;
    else if (pennies >= 1)
        pennies -= 1;

    coins++;
}

Console.WriteLine(coins);