// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число A: ");
double A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
double B = Convert.ToInt32(Console.ReadLine());
 

 double ExpoAtoB (double A1, double B1)
 {
      return Math.Pow(A1,B1); // Math.Pow Возвращает указанное число, возведенное в указанную степень.
         
 }

double result = ExpoAtoB(A,B);
Console.WriteLine($"{A} в степени {B} равно {result}");
