using System.Globalization;

double tripPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double curMoney = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

int conseqDaysSpent = 0;
int totalDays = 0;

while (curMoney < tripPrice)
{
    totalDays++;
    
    string action = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (action == "spend")
    {
        curMoney -= sum;

        if (curMoney < 0)
            curMoney = 0;
        
        conseqDaysSpent++;

        if (conseqDaysSpent == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(totalDays);
            break;
        }
    }
    else
    {
        curMoney += sum;
        conseqDaysSpent = 0;
    }
}

if (curMoney >= tripPrice)
    Console.WriteLine($"You saved the money for {totalDays} days.");
