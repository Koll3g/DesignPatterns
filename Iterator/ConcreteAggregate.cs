namespace Iterator;

/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>

public class ConcreteAggregate : IAggregate
{
    List<object> items = new List<object>();

    public override IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    // Get item count

    public int Count
    {
        get { return items.Count; }
    }

    // Indexer

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}