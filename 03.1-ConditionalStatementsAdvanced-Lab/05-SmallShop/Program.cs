using System.Globalization;

string product = Console.ReadLine();
string city = Console.ReadLine();
double qty = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double price = 0.0;

switch (city)
{
    case "Sofia":
        if (product == "coffee")
            price = qty * 0.5;
        else if (product == "water")
            price = qty * 0.8;
        else if (product == "beer")
            price = qty * 1.2;
        else if (product == "sweets")
            price = qty * 1.45;
        else
            price = qty * 1.6;
        break;
    case "Plovdiv":
        if (product == "coffee")
            price = qty * 0.4;
        else if (product == "water")
            price = qty * 0.7;
        else if (product == "beer")
            price = qty * 1.15;
        else if (product == "sweets")
            price = qty * 1.3;
        else
            price = qty * 1.5;
        break;
    case "Varna":
        if (product == "coffee")
            price = qty * 0.45;
        else if (product == "water")
            price = qty * 0.7;
        else if (product == "beer")
            price = qty * 1.1;
        else if (product == "sweets")
            price = qty * 1.35;
        else
            price = qty * 1.55;
        break;
}

Console.WriteLine(price);