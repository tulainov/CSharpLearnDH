using static ClassesCode.ClassesTasks.Lotto.Lotto;

namespace ClassesCode.ClassesTasks.Lotto;

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