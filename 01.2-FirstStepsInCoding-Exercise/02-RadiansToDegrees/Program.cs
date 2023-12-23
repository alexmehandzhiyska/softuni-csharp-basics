using System.Globalization;

double rad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double deg = rad * 180 / Math.PI;

Console.WriteLine(deg);