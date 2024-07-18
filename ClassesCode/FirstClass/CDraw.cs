using static ClassesCode.FirstClass.Lotto;

namespace ClassesCode.FirstClass;

public class CDraw
{

    public static void Run()
    {
        int count = 0;

        while (count < 10)
        {
            NumberGenerator();
            Console.WriteLine("Generated numbers: " + string.Join(", ", NumList));
            NumList.Clear();
            Thread.Sleep(100);
            count++;
        }
    }
}