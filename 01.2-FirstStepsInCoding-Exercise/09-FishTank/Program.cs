int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double volume = (length * width * height) * 0.001;
double freeVolume = volume * (1 - percent / 100);

Console.WriteLine(freeVolume);