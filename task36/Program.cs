// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

const int SIZE = 10;
const int LEFTRANGE = -5;
const int RIGHTRANGE = 10;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine(string.Join(", ", arr));

int sum = 0;

for (int i = 0; i < arr.Length; i += 1)
{
    if (i % 2 == 0)
    {
        sum = sum + 0;
    }
    else
    {
        sum = sum + arr[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");

