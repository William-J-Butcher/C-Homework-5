// Задача 38: 
// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Array(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        Console.Write($"{arr[i]}, ");
    }
Console.WriteLine("\b\b ]");
}
int GetMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}
int GetMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}
int[] array = new int[5];
void Messages()
{
    int result = GetMax(array) - GetMin(array);
    Console.WriteLine($"Минимальный элемент массива - {GetMin(array)}");
    Console.WriteLine($"Максимальный элемент массива - {GetMax(array)}");
    Console.WriteLine($"Разница между мамксимальным и минимальным элементами массива - {result}");
}
Array(array);
GetMin(array);
Messages();
