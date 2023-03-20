//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2



 


void FillArray(int[]array)
{  
    Console.Write("Случайный массив: ");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write($" {array[i]};");   
    }
    
}

void EvenNums (int[]arra)
{
    int res = 0;
    for (int j = 0; j < arra.Length; j++)
    {
        
        if (arra[j] % 2 == 0) 
        {
            
            res = res + 1;
        }   
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел в массиве: {res}");
}


 int[] example = new int[new Random().Next(4, 10)];   
FillArray(example);
EvenNums(example);




