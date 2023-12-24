int maxNum = int.Parse(Console.ReadLine());
int curNum = 1;
int row = 1;
int curRowNums = 0;

while (curNum <= maxNum)
{
    if (curRowNums < row)
    {
        Console.Write(curNum + " ");
    }
    else
    {
        Console.Write($"\n{curNum} ");
        row++;
        curRowNums = 0;
    }

    curRowNums++;
    curNum++;
}