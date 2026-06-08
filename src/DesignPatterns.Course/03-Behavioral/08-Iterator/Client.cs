using DesignPatterns.Course._03_Behavioral._08_Iterator.Interfaces;

namespace DesignPatterns.Course._03_Behavioral._08_Iterator;

public class Client
{
    public void ConsumeDataStructure()
    {
        Aggregate aggregate = new Aggregate();

        aggregate[0] = "Item 01";
        aggregate[1] = "Item 02";
        aggregate[2] = "Item 03";

        IIterator iterator = aggregate.GetIterator();

        for (string item = iterator.Next; iterator.HasNext; item = iterator.Next)
        {
            Console.WriteLine(item);
        }
    }
}
