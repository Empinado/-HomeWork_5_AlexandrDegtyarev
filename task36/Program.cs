// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] FillArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 10);
    }
    return Array;
}

int[] arr = FillArray(size);

Console.WriteLine();
Console.WriteLine("[" + String.Join(",", arr) + "]");
Console.WriteLine();

int Sum = 0;

// int count=1;

// while(count<arr.Length)
// {
//     Sum = Sum + arr[count];
//     count+=2;
// }

for (int i = 1; i < arr.Length; i = i + 2)
{
    Sum = Sum + arr[i];
}

Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях, равна:" + $"{Sum}");