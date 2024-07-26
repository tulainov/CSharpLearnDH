namespace ClassesCode.ClassesTasks.LuckyNumber;

public class LuckyNumber
{

    private string Name;
    private string[] SplitName;
    private char FirstLetter;
    private char LastLetter;
    
    private void UserName()
    {
        
        Console.WriteLine("\nAre you ready to find out what's your lucky number??");
        Console.WriteLine("\nIf so, enter your name and surname:");

        Name = Console.ReadLine();

        if (string.IsNullOrEmpty(Name) || Name.Split(' ').Length < 2)
        {
            throw new Exception("Name and surname are mandatory!");
        }
        else
        {
            Console.WriteLine($"Hello {Name}!");
        }
    }

    private void SplitUserName()
    {

        SplitName = Name.Split(' ');

        FirstLetter = Convert.ToChar(SplitName[0][0]);
        LastLetter = Convert.ToChar(SplitName[SplitName.Length - 1]
            [SplitName[SplitName.Length - 1].Length - 1]);
    }

    private int GetCharSum()
    {

        int first = Convert.ToInt32(FirstLetter);
        int second = Convert.ToInt32(LastLetter);

        return first + second;
    }

    public void Run()
    {

        UserName();
        SplitUserName();

        Random random = new Random(GetCharSum());
        int luckyNumber = random.Next();
        
        Console.WriteLine($"Your lucky number is {luckyNumber}\nCongratulations!");
    }
    
}