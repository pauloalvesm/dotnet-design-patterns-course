using DesignPatterns.Course._03_Behavioral._08_Iterator.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._08_Iterator;

public class Aggregate : IAggregate
{
    private readonly List<string> _collection;

    public Aggregate()
    {
        _collection = new List<string>();
    }

    public IIterator GetIterator()
    {
        return new Iterator(this);
    }

    public string this[int index]
    {
        get
        {
            if (index < _collection.Count)
            {
                return _collection[index];
            }
            else
            {
                return string.Empty;
            }
        }
        set
        {
            _collection.Add(value);
        }
    }

    public int Limit
    {
        get
        {
            return _collection.Count;
        }
    }
}
