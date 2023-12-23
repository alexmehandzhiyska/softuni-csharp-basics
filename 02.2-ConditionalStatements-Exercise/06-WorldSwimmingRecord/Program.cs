using System.Globalization;

double record = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double distance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double timePerMeter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double time = distance * timePerMeter;
double delayTime = Math.Floor(distance / 15) * 12.5;
double totalTime = time + delayTime;

if (totalTime < record)
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
else
    Console.WriteLine($"No, he failed! He was {(totalTime - record):f2} seconds slower.");
