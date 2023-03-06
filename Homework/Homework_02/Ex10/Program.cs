// 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введи трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
Console.WriteLine("вторая цифра этого числа  "+stringNumber[1]);
