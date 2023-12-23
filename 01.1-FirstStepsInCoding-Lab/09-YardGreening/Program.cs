double area = double.Parse(Console.ReadLine());

double price = area * 7.61;
double discount = price * 0.18;

Console.WriteLine($"The final price is: {price - discount} lv.");
Console.WriteLine($"The discount is: {discount} lv.");