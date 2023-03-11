
// ВозвращаемыйТипДанный ИмяМетода([ТипДанных1 ИмяАргумента1, ...])
// {
//    Тело Метода
//    return ЗначениеСоответствующееВозвращаемомуТипуДанных;
// }


// Группы методов:

// 1. Ничего не получают и ничего не возвращают (Void)

void Method()
{
    Console.WriteLine("Автор ...");
}

Method(); // Способ вызова методов.
//------------------------------------------------------------------------------//
// 2. Принимают аргументы, но ничего не возвращают (Void)

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");
//----------------------------------------//
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4); // Вызов метода может быть как с указанием имен элементов, так и без, просто через запятую.
//---------------------------------------------------------------------------------//

// 3. Могут что-то возвращать, но не принимают никаких аргументов

int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3(); // переменной 'year' присвоено значение вывода метода.
Console.WriteLine(year);
//---------------------------------------------------------------------------------//
// 4. Что-то принимают и что-то возвращают

string Method4(int count, string text)
 {
      int i = 0;
      string result = string.Empty;
      while (i < count)
      {
          result = result + text;
          i++;
      }
      return result;
 }
 string res = Method4(10, "asdf");
 Console.WriteLine(res);
//---------------------------------------------------------------------------------//

string Method4(int count, string text)
{

    string result = string.Empty;
    for (int i = 0; i < count; i++)

    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);

// Вывод таблицы умножения на экран.

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j} "); // Способ - интерполяция строк?**
    }
    Console.WriteLine();
}
 
 
 // ** Для определения строкового литерала в качестве интерполированной строки добавьте к началу символ $.
 // Вы можете внедрить любое допустимое выражение C#, возвращающее значение в интерполированной строке. В 
 // следующем примере после вычисления выражения его результат преобразуется в строку и включается в строку результатов:
 // double a = 3;
 // double b = 4;
 // Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
 // Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

 // double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

 // Expected output:
 // Area of the right triangle with legs of 3 and 4 is 6
 // Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5
 