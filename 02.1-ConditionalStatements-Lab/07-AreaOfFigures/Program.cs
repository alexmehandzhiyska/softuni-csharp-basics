string shape = Console.ReadLine();
double area = 0.0;

if (shape == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
}
else if (shape == "rectangle")
{
    double length =  double.Parse(Console.ReadLine());
    double width =  double.Parse(Console.ReadLine());
    area = length * width;
}
else if (shape == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = radius * radius * Math.PI;
}
else
{
    double side = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    area = (side * height) / 2;
}

Console.WriteLine($"{area:f3}");