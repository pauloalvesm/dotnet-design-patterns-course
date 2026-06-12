namespace DesignPatterns.Course._03_Behavioral._08_Iterator.Interfaces;

public interface IIterator
{
    string Next { get; }
    bool HasNext { get; }
}
