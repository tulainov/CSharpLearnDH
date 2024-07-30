using System.Collections;

namespace ClassesCode.ClassesTasks.Iterators.People;

public interface IEnumerable<out T>: IEnumerable
{
    IEnumerator<T> GetEnumerator();
}