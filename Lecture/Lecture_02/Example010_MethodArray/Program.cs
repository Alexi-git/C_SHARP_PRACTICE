﻿int[] array = {1, 12, 31, 4, 59, 15, 16, 31, 17, 18 };

int n = array.Length;
int find = 59;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}
