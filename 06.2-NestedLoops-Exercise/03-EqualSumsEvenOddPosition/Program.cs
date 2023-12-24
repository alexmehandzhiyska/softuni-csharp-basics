string command = Console.ReadLine();

int sumPrime = 0, sumNonPrime = 0;

while (command != "stop")
{
    int num = int.Parse(command);

    if (num < 0)
    {
        Console.WriteLine("Number is negative.");
        command = Console.ReadLine();
        continue;
    }
    
    bool isPrime = true;

    for (int divisor = 2; divisor < num; divisor++)
    {
        if (num % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
        sumPrime += num;
    else
        sumNonPrime += num;
    
    command = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");