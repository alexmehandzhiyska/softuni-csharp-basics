int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int volume = width * length * height;

string command = Console.ReadLine();

while (command != "Done")
{
    int boxes = int.Parse(command);

    volume -= boxes;

    if (volume <= 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
        break;
    }

    command = Console.ReadLine();
}

if (volume > 0)
    Console.WriteLine($"{volume} Cubic meters left.");