using System.Collections;
using System.Collections.Generic;

namespace ClassesCode.FirstClass;

public class Generics
{
    
    #region other tasks

    public static void Run()
    {
        const int capacity = 1_000_000;

        long before, diff;
        
        // start working with ArrayList

        before = DateTime.Now.Ticks;

        ArrayList nums = new ArrayList();

        for (int i = 1; i <= capacity; i++)
        {
            nums.Add(i);
        }
        
        diff = DateTime.Now.Ticks - before;
        Console.WriteLine("Time in milliseconds for ArrayList: " + diff/10e4);
        
        // start working with List<T>

        before = DateTime.Now.Ticks;

        List<int> ints = new List<int>();

        for (int i = 1; i < capacity; i++)
        {
            ints.Add(i);
        }
        
        diff = DateTime.Now.Ticks - before;
        
        Console.WriteLine("Time in milliseconds for List<T>: " + diff/10e4);
    }

    public static T Max<T>(T x, T y) where T:IComparable<T>
    {
        return x.CompareTo(y) >= 0 ? x : y;
    }

    #endregion
    
    public static void getKeyPairValues(string sentence)
    {
        
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
    }
}