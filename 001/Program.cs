// Задать массив из 8 элементов и вывести их на экран
// Задать массив из 8 элементов и вывести их на экран

void FillArray (int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(0, 2);
        index++;
    } 
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(array[position]);
        position++;
        
    }
}
int[] Array = new int[8];
FillArray(Array);
PrintArray(Array);

