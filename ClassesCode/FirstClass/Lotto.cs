namespace ClassesCode.FirstClass;

/// <summary>
/// Create a class that creates 6 Lotto numbers in the List, sorts them.
/// Numbers cannot be duplicated.
/// Create class CDraw with method Run, that will imitate the Main().
/// In Main method call Run method 10x with Thread.Sleep(10) after each.
///
///
/// I can also use here instead of List - HashTable, HashMap. It takes only unique numbers
/// and throws an exception if number duplicates. So many things to learn!
/// </summary>



public class Lotto
{
    private static List<int> _numList = new();

    public static List<int> NumList
    {
        get => _numList;
    }
    
    public static List<int> NumberGenerator()
    {

        for (int i = 0; i < 6; i++)
        {
            Random random = new Random();
            int number = random.Next(49) + 1;
            
            if(!IsDuplicate(_numList, number))
            {
                _numList.Add(number);
            }
        }
        
        _numList.Sort();

        return _numList;
    }

    private static bool IsDuplicate(List<int> list, int number)
    {

        foreach (var num in list)
        {
            if (num == number)
            {
                return true;
            }
        }

        return false;
    }
}