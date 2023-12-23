double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());
string title = "";

switch (gender)
{
    case 'm':
        if (age < 16)
            title = "Master";
        else
            title = "Mr.";
        break;
    
    case 'f':
        if (age < 16)
            title = "Miss";
        else
            title = "Ms.";
        break;
}

Console.WriteLine(title);