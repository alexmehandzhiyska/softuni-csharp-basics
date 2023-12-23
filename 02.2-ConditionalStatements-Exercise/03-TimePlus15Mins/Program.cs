int hour = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());

int totalTime = hour * 60 + min + 15;

int newHour = totalTime / 60;
int newMin = totalTime % 60;

if (newHour == 24)
    newHour = 0;

if (newMin < 10)
    Console.WriteLine($"{newHour}:0{newMin}");
else
    Console.WriteLine($"{newHour}:{newMin}");