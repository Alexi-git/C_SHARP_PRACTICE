int max,min;

Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());

max = 0;
min = 0;

if (a>b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);