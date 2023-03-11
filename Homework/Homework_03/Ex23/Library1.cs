public static class Library1
{

    public static void FillIn(int[] cube)
    {
        for (int counter = 0; counter < cube.Length; counter++)
        {
            cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        }
    }

}