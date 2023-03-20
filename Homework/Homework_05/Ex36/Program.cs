//Задача 36: Задайте одномерный массив, заполненный случайными числами. Н
//айдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0


void PrintArray(int[] arr)
{
    Console.Write($"Одномерный массив случайных чисел: ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}.");
}

void SetArray(int[] arry)
{
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(-99, 99);

    }
}

void SumNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 && array[i] % 2 == 0)
        {
            result = result + array[i];
        }

    }
    Console.WriteLine();
    Console.WriteLine($"Сумма четных чисел в массиве: {result}");
}

int[] example = new int[new Random().Next(2, 10)];
SetArray(example);
PrintArray(example);
SumNumbers(example);
