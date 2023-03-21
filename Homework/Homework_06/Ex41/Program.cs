//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

    Console.Write("Желаемое количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] Array = new int[M];
    

void input(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

int count(int[] arr)
{
    int i = 0;
    int sum = 0;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum = sum + 1;
    }
    return sum;
}



input(M);
Console.Write($"Чисел больше нуля: {count(Array)}");

