﻿//Напишите метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

using static Library1;
using static Library2;

Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

int[] arry = new int[cube + 1];
FillIn(arry);
PrintArry(arry);