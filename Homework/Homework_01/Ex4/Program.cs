int max;

Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение c: ");
int c = Convert.ToInt32(Console.ReadLine());

max = 0;

if (a>b)
{
    max = a;
}
else
{
    max = b;
}


if (c>max)
{
max = c;
}
else
{
Console.Write("max = ");
Console.WriteLine(max);
}



