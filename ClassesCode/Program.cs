using System;
// using static ClassesCode.ClassesTasks.Lotto.CDraw;
// using static ClassesCode.ClassesTasks.Generics;
using ClassesCode.ClassesTasks.LuckyNumber;

namespace ClassesCode
{
    public class ClassCode
    {
        public static void Main(String[] args)
        {

            // Run();
            // Console.WriteLine("int-max:\t" + Max(13, 12)); 
            // Console.WriteLine("double-max:\t" + Max(2.16, 47.11)); 
            // Console.WriteLine("String-max:\t" + Max("abc", "def")); 

            LuckyNumber luckyNumber = new LuckyNumber();
            
            luckyNumber.Run();
        }
    }
}