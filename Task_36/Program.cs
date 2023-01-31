// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void GetArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 30);
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b ] -> ");
}
int Sum(int[] coll)
{
    int sum = 0;
        for (int i = 0; i < coll.Length; i++)
        {
            if(i % 2 != 0) sum += coll[i];
        }
        return sum;
}
int[] arr = new int[4];
GetArray(arr);
Sum(arr);
Console.Write($"Сумма чисел на нечетных позициях - {Sum(arr)}");