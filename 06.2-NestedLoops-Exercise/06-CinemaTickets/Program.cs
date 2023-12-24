string command = Console.ReadLine();

int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;

while (command != "Finish")
{
    string movieName = command;
    int totalSpaces = int.Parse(Console.ReadLine());
    int takenSpaces = 0;

    string command1 = Console.ReadLine();

    while (command1 != "End")
    {
        string ticketType = command1;

        if (ticketType == "student")
            studentTickets++;
        else if (ticketType == "standard")
            standardTickets++;
        else
            kidTickets++;

        takenSpaces++;

        if (takenSpaces == totalSpaces)
            break;

        command1 = Console.ReadLine();
    }

    double percentFull = (double)takenSpaces / totalSpaces * 100;
    Console.WriteLine($"{movieName} - {percentFull:f2}% full.");
    
    command = Console.ReadLine();
}

int totalTickets = studentTickets + standardTickets + kidTickets;
Console.WriteLine($"Total tickets: {totalTickets}");

double studentPercent = (double)studentTickets / totalTickets * 100;
double standardPercent = (double)standardTickets / totalTickets * 100;
double kidPercent = (double)kidTickets / totalTickets * 100;

Console.WriteLine($"{studentPercent:f2}% student tickets.");
Console.WriteLine($"{standardPercent:f2}% standard tickets.");
Console.WriteLine($"{kidPercent:f2}% kids tickets.");