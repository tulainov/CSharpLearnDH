using System.Diagnostics;

namespace ClassesCode.ClassesTasks.Iterators.BubbleSortTask;

public class BubbleSorter
{

    public static void Run()
    {
        
        int[] array = { 1, 4, 32, 12, 6, 7, 8, 0, 3212, 21, 2, 1, 547, 43, 12, 11 };

        Stopwatch stopwatch = Stopwatch.StartNew();
        
        Console.WriteLine("Unsorted array: \n");

        foreach (var value in array)
        {
            Console.Write(value + " ");
        }

        BubbleSorter sorter = new BubbleSorter();
        
        sorter.BubbleSort(array);

        Console.WriteLine("\nSorted array: \n");
        
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        
        stopwatch.Stop();

        Console.WriteLine($"\nThe running time {stopwatch.ElapsedMilliseconds} ms");
    }
    
    public void BubbleSort<T> (T[] array) where T: IComparable<T>
    {
        

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    
                    // swapping elements of an array
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                }
            } 
        }
    }
}