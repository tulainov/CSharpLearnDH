namespace CSharpCourseDH.ExamTask.FirstTask;

public class CAnimal
{
    private int _noOfLegs;
    private bool _hasWings;

    public CAnimal(bool hasWings)
    {
        _hasWings = hasWings;
    }


    #region properties
    
    public int NoOfLegs
    {
        get => _noOfLegs;
        set => _noOfLegs = value;
    }

    public bool HasWings
    {
        get => _hasWings;
        set => _hasWings = value;
    }
    
    #endregion

    
    /// <summary>
    /// The method Move() has to be in CAnimal because all animals have the ability
    /// of moving.
    /// </summary>
    public virtual void Move()
    {
        Console.WriteLine("The animals walk two by two, hurray, hurray");
    }
    
}