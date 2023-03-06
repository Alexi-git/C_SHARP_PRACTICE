// 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введи цифру, обозначающую день недели (1-7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
               
void DayOfTheWeek (int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("неверный ввод, читай условие");
  }
  else Console.WriteLine("этот день не выходной");
}

DayOfTheWeek(dayNumber);