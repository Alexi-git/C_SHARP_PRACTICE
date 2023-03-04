// Написать программу, которая на вход получает массив,
// а на выходе собирает новый массив только из чисел, крастных 5-ти.

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

int[] arrNew = new int[count];
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

index = 0;
while (index < arrNew.Length)
{
    System.Console.WriteLine(arrNew[index]);
    index++;
}