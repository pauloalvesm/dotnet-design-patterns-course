namespace DesignPatterns.Course._03_Behavioral._08_Iterator.Interfaces;

public interface IAggregate
{
    IIterator GetIterator();
    string this[int index] { get; set; }
    int Limit { get; }
}