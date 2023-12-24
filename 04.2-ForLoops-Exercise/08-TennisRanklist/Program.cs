int tournaments = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int pointsWon = 0;
int wins = 0;

for (int curTournament = 1; curTournament <= tournaments; curTournament++)
{
    string status = Console.ReadLine();

    if (status == "W")
    {
        pointsWon += 2000;
        wins++;
    }
    else if (status == "F")
    {
        pointsWon += 1200;
    }
    else
    {
        pointsWon += 720;
    }
}

int totalPoints = initialPoints + pointsWon;
Console.WriteLine($"Final points: {totalPoints}");

double avgPoints = Math.Floor((double)pointsWon / tournaments);
Console.WriteLine($"Average points: {avgPoints}");

double winPercent = (double)wins / tournaments * 100;
Console.WriteLine($"{winPercent:f2}%");

