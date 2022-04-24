// Задача 6. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Array[index] = new Random().Next(100, 1000);
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
int[] Array = new int[10];
FillArray(Array);
PrintArray(Array);

int l = Array.Length;
int odd = 0;
int even = 0;
int i = 0;
while (i < l)
{
    if (Array[i] % 2 == 0) even++;
    else odd++;
    i++;
}

System.Console.WriteLine($"Четных - {even}, Нечетных - {odd}");