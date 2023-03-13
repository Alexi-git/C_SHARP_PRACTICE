// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


using static Library1;

Console.Write("Введите число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());

int sum = NumberSum(UserNumber);
Console.WriteLine($"Сумма цифр в числе: {sum}.");