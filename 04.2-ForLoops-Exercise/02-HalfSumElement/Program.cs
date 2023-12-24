using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());

int max = 0;
int sum = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;

    if (num > max)
        max = num;
}

int restSum = sum - max;

if (max == restSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {restSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(max - restSum)}");
}