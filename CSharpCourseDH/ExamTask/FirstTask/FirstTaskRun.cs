using CSharpCourseDH.ExamTask.FirstTask;

namespace CSharpCourseDH.ExamTask.FirstTask;

public class FirstTaskRun
{
    public static void Run()
    {

        CBird parrot = new CBird();

        Console.WriteLine($"The parrot has {parrot.NoOfLegs} legs");
        Console.WriteLine($"The parrot has wings? {parrot.HasWings}");
        
        parrot.Hatch();
        parrot.Move();
    }
}