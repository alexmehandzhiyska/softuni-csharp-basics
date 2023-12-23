int initialPoints = int.Parse(Console.ReadLine());
double bonusPoints = 0.0;

if (initialPoints <= 100)
    bonusPoints = 5;
else if (initialPoints <= 1000)
    bonusPoints = 0.2 * initialPoints;
else
    bonusPoints = 0.1 * initialPoints;

if (initialPoints % 2 == 0)
    bonusPoints += 1;
else if (initialPoints % 10 == 5)
    bonusPoints += 2;
    
    
Console.WriteLine(bonusPoints);
Console.WriteLine(initialPoints + bonusPoints);