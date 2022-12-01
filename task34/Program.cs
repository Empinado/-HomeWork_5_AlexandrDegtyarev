// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] Array = new int[20];
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100, 1000);

}

Console.WriteLine("[" + string.Join(",", Array) + "]");


for (int j = 0; j < Array.Length; j++)
{
    if (Array[j] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве = {count}");