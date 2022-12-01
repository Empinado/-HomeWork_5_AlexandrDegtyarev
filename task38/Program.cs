// Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

double[] FillingArray(int size)
{
    double[] outArray = new double[size];
    int i = 0;
    System.Random numberSintezator = new System.Random();

    while (i < size)
    {
        //Заполняем массив вещественными числами и округляем их до 2 знаков после запятой
        outArray[i] = numberSintezator.Next(-3, 3) + numberSintezator.NextDouble();
        outArray[i] = Math.Round(outArray[i], 3);
        i++;
    }
    return outArray;
}

double[] arr = FillingArray(size);

Console.WriteLine();
Console.WriteLine("[" + String.Join(", ", arr) + "]");
Console.WriteLine();

double numMax = 0;

for (int i = 0; i < arr.Length; i++)
{

    if (numMax < arr[i])
    {
        numMax = arr[i];
    }
}

Console.WriteLine($"Максимальное число в массиве:{numMax}");

double numMin=0;

for (int i = 0; i < arr.Length; i++)
{

    if (numMin > arr[i])
    {
        numMin = arr[i];
    }
}

Console.WriteLine($"Минимальное число в массиве:{numMin}");


double diff = numMax - Math.Abs(numMin);

Console.WriteLine($"Разница между максимальным и минимальным числом в массиве:{Math.Round(diff,3)}");