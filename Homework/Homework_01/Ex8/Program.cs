Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = 2;

if(number > 1)
{
    while(even <= number)
    {
        Console.Write(even + " ");
        even = even + 2;
    }
}