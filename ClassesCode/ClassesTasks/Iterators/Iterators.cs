namespace ClassesCode.ClassesTasks.Iterators;

public class Iterators
{

    public static void Run()
    {
        foreach (int number in EvenSequence(3, 12))
        {
            Console.Write(number.ToString() + " ");
        }
    }

    public static System.Collections.Generic.IEnumerable<int> EvenSequence(int firstNum, int secondNum)
    {

        for (int number = firstNum; number <= secondNum; number++)
        {
            if (number % 2 == 0)
            {
                yield return number;
            }
        }
    }
}