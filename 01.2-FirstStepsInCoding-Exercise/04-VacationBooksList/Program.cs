int pagesCount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int hours = pagesCount / pagesPerHour;
int hoursPerDay = hours / days;

Console.WriteLine(hoursPerDay);