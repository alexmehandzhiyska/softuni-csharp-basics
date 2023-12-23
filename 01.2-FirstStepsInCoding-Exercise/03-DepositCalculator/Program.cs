using System.Globalization;

double depositedSum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int periodInMonths = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double annualInterestPercent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double annualInterestDecimal = annualInterestPercent / 100;
double sum = depositedSum + periodInMonths * ((depositedSum * annualInterestDecimal) / 12);

Console.WriteLine(sum);