// Написать программу, которая на вход получает массив,
// а на выходе собирает новый массив только из чисел, крастных 5-ти.
//DmitriyLosev
// Семинар 2 1:51:08 - методы получения массива, метод получения суммы, клиентский код
// Семинар 1:53:25 - метод создания массива, метод заполнения массива, метод печати массива, метод создания другого массива
// на основе первого, состоящего из четных чисел.


int[] arr = { 10, 13, 25, 45, 34, 83 };

int count = 0;
int index = 0;

while (index < arr.Length)
{
    if (arr[index] % 5 == 0)
    {
        count++;
    }
    index++;
}

int[] arrNew = new int[count]; // new int [x] - задание массива с X количеством элементов в нем. 
//Этой строкой мы задали количество элементов в массиве int[] arrNew
index = 0;
int indexNew = 0;

while (index < arr.Length)
{
    if (arr[index] % 5 == 0)
    {
        arrNew[indexNew] = arr[index];
        indexNew++;
    }
     index++;   
}

// Метод печати массива:
index = 0;
while (index < arrNew.Length)
{
    System.Console.WriteLine(arrNew[index]);
    index++;
}