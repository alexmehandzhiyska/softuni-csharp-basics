﻿string name = Console.ReadLine();

switch (name)
{
    case "dog":
        Console.WriteLine("mammal");
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile");
        break;
    default:
        Console.WriteLine("unknown");
        break;
}