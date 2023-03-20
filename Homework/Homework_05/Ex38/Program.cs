//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


void SetArray(double[] arr)
{
    Console.Write($"Массив вещественных чисел: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble();
        Console.Write($" {arr[i]}; ");

    }
}
    
  //------------------------------------------------------  
    void FindDif(double[] arr1)
{
    double max = arr1[0];
    int Max = 0;
    int Min = 0;
    double min = arr1[0];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] < arr1[Min]) 
        {
        min = arr1[i];
        Min = Min + 1;
        }
        if (arr1[i] > arr1[Max]) 
        {
        max = arr1[i];
        Max = Max + 1;
        }
        
    }
    double result = 0;
    result = max - min;
    Console.WriteLine();
    Console.WriteLine($"Разность между максимальным и минимальным элементом массива равна: {result}");
}


//-----------------------------------------------



double[] example = new double[new Random().Next(2, 10)];
SetArray(example);
FindDif(example);
