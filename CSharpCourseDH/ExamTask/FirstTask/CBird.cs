namespace CSharpCourseDH.ExamTask.FirstTask;

public class CBird: CAnimal
{

    public CBird() : base(true)
    {
        NoOfLegs = 2;
    }
    
    /// <summary>
    /// The method Hatch() has to be implemented in CBird
    /// because only birds from mammals have the ability of hatching
    /// </summary>
    public void Hatch()
    {
        Console.WriteLine("The new bird is born! Hurray!");
    }
    
    public override void Move()
    {
        Console.WriteLine("The birds walk two by two, hurray, hurray");
    }
}