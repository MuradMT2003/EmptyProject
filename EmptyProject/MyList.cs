
using System.Collections;
namespace EmptyProject;
public class MyList<T> : IEnumerable
{
    T[] arr;
    int count = 0;
    public MyList()
    {
        arr = new T[0];
    }
    public void Add(T item)
    {
        count++;
        Array.Resize(ref arr, count);
        arr[^1] = item;
    }
    public void Remove(T item)
    {
        if (count <= 1)
        {
            return;
        }
        T[] narr = new T[count - 1];
        for (int i = 0; i < arr.Length; i++)
        {
            if (!arr[i].Equals(item))
            {
                narr[i] = arr[i];
            }
        }
        arr = narr;
    }
    public int Count
    {
        get
        {
            return count;
        }
    }
    public void Clear()
    {
        count = 0;
        Array.Resize(ref arr, count);
    }
    public T this[int index]
    {
        get
        {
            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    }


    public IEnumerator GetEnumerator()
    {

        foreach (var item in arr)
        {
            yield return item;
        }

    }
}

