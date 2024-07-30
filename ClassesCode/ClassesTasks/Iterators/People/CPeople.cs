using System.Collections;

namespace ClassesCode.ClassesTasks.Iterators.People;

public class CPeople: IEnumerable<CPerson>
{
    private CPerson[] people;

    public CPeople(CPerson[] pArray)
    {
        people = new CPerson[pArray.Length];
        for (int i = 0; i < pArray.Length; i++)
            people[i] = pArray[i];
    }

    public IEnumerator<CPerson> GetEnumerator()
    {
        for (int i = 0; i < people.Length; i++)
        {
            yield return people[i];
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new CPeopleEnum(people);
    }
}