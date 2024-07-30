﻿namespace ClassesCode.ClassesTasks.Iterators.People;

public class CPerson
{

    public CPerson(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
    }

    public string FirstName
    {
        get;
        set;
    }

    public string LastName
    {
        get;
        set;
    }
}