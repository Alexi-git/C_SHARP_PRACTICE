



double Factorial(int n) // Факториал начиная от факториала 17-ти - это 
//слишком большое число для типа данных integer, поэтому мы заменям тип данных на double 
//для возвращаемого элемента
{
    //1! = 1
    //0! = 1
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
for(int i = 1; i < 40; i++)
{
Console.WriteLine(Factorial(i));
}
