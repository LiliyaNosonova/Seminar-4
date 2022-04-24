// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива

void FillArray (int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(0, 10);
        index++;
    } 
}

void PrintArray(int[] Array)
{
    int count = Array.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(Array[position]);
        position++;        
    }
}
int[] Massive = new int[12];
FillArray(Massive);
PrintArray(Massive);

int SumPositive(int[] Massive)
{
    int L = Massive.Length;
    int SumPos = 0;
    for (int i = 0; i < L; i++)
    {
        if (Massive[i] > 0)
        {
            SumPos = SumPos + Massive[i];
        }
    }
    return SumPos;
}

int SumNegative(int[] Massive)
{
    int L = Massive.Length;
    int SumNeg = 0;
    for (int i = 0; i < L; i++)
    {
        if (Massive[i] < 0)
        {
            SumNeg = SumNeg + Massive[i];
        }
    }
    return SumNeg;
}
int[] negative = {-1, -8, 5, 0};
//int resultnegative = SumNegative(Massive);
//int result = SumPositive(Massive);
System.Console.WriteLine();
System.Console.WriteLine(SumPositive(Massive));
System.Console.WriteLine();
System.Console.WriteLine(SumNegative(negative));