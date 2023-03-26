public class Exercises
{

    public static bool LessThan100(int a, int b)
    {
        var sum = Sum(a, b) ;
        var result = sum < 100;
        return result;

    }


    public static int Sum(int number1, int number2)
    {
        return (number1 + number2);

    }

}