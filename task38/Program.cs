// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 100;


int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));


int minValue = arr[0];
int maxValue = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < minValue)
    {
        minValue = arr[i];
    }
    if (arr[i] > maxValue)
    {
        maxValue = arr[i];
    }
}

Console.WriteLine($"Разница между максимальным числом {maxValue} и минимальным числом {minValue} = {maxValue - minValue}");
