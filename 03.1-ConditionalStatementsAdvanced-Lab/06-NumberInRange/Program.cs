using System.Globalization;

double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if ((num >= -100 && num <= 100) && num != 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");