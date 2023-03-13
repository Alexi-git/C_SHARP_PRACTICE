public static class Library1
{

    public static int NumberSum(int UserNumber)
    {

        int counter = Convert.ToString(UserNumber).Length;
        int Step = 0;
        int result = 0;

        for (int i = 0; i < counter; i++)
        {
            Step = UserNumber - UserNumber % 10; // numberN % 10 - результат действия 
                                                 //это последняя цифра числа. (В результате условно было 356, отсталось 350)
            result = result + (UserNumber - Step); // в результате дейсвия
                                                   // к result суммируется последняя цифра при каждой итерации (условно 356 - 350 = 6;)
            UserNumber = UserNumber / 10; // делим условные 356 на 10, и т.к у нас тип данных Int, 
                                          //то результатом будет целое число 
        }
        return result;
    }

}