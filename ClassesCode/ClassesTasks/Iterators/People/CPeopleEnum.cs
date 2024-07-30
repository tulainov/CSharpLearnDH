using System.Collections;

namespace ClassesCode.ClassesTasks.Iterators.People;

public class CPeopleEnum: IEnumerator
{

    public CPerson[] _people;

    private int position = -1;

    public CPeopleEnum(CPerson[] list)
    {
        _people = list;
    }

    public bool MoveNext()
    {
        position++;
        position++;
        return (position < _people.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get { return Current; }
    }

    public CPerson Current
    {
        get { return _people[position]; }
    }
}