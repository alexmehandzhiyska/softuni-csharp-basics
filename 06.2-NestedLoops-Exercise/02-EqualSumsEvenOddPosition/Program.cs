int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int num = start; num <= end; num++)
{
    string numStr = num.ToString();
    int sumEvenPos = 0;
    int sumOddPos = 0;

    for (int i = 0; i < numStr.Length; i++)
    {
        if (i % 2 == 0)
            sumEvenPos += numStr[i];
        else
            sumOddPos += numStr[i];
    }
    
    if (sumEvenPos == sumOddPos)
        Console.Write(numStr + " ");
}