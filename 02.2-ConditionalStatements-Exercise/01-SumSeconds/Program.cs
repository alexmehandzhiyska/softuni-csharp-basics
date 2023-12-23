int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());

int totalTime = time1 + time2 + time3;

int mins = totalTime / 60;
int seconds = totalTime % 60;

if (seconds < 10)
    Console.WriteLine($"{mins}:0{seconds}");
else
    Console.WriteLine($"{mins}:{seconds}");