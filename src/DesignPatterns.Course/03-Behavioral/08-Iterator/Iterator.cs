using DesignPatterns.Course._03_Behavioral._08_Iterator.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._08_Iterator;

public class Iterator : IIterator
{
    private readonly IAggregate _aggregate;
    private int _position;

    public Iterator(IAggregate aggregate, int position = 0)
    {
        _aggregate = aggregate;
        _position = position;
    }

    public string Next
    {
        get
        {
            return _aggregate[_position++];
        }
    }

    public bool HasNext
    {
        get
        {
            return _position <= _aggregate.Limit;
        }
    }
}