﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("Ваше число является палиндром.");
  }
  else Console.WriteLine("Ваше число не является палиндром.");
}

if (number.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine("Введи правильное число");