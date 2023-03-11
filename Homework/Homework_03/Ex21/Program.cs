// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

double FindingLength(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + // Math.Sqrt возвращает квадратный корень из указанного числа
                     Math.Pow((y2 - y1), 2) + // Math.Pow Возвращает указанное число, возведенное в указанную степень.
                     Math.Pow((z2 - z1), 2));
}

double Length = Math.Round(FindingLength(x1, x2, y1, y2, z1, z2), 2); // Math.Round Округляет значение до ближайшего целого или указанного количества десятичных знаков.

Console.WriteLine($"Длина отрезка  {Length}");