public static class Library2
{
public static void PrintArry(int[] call)
{
    int count = call.Length;
    for (int index = 1; index < count; index++)
    {
        Console.Write(call[index] + " ");

    }
}

}