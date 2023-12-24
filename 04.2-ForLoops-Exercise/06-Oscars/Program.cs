using System.Globalization;

string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
int judgeCount = int.Parse(Console.ReadLine());

for (int curJudge = 1; curJudge <= judgeCount; curJudge++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    points += (judgeName.Length * judgePoints) / 2;

    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
        break;
    }
}

if (points < 1250.5)
    Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - points):f1} more!");