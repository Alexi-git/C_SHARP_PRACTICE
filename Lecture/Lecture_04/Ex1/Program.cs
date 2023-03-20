// Двумерные массивы
// Рекурсия

//string[,] table = new string[2, 5];
// String.Empty - константа для инициализации строки!!
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]
//table[1, 2] = "слово";

// Метод печати двумерного массива:
//------------------------------------------
//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}
//
//--------------------------------------------------------------------------------------------------

void PrintArray(int[,] matr) //вместо Matrix, передаем другое название matr.
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) - эта конструкция выдает 
                                                  //количество строк или столбцов. В скобках, если указать 0, то считает строки, а если 1, то столбцы.
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();//Добавили строку для вывода в консоли в виде таблицы.
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            matr[i,j] = new Random().Next(1,10);//
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);