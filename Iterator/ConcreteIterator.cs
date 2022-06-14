namespace Iterator;

/// <summary>
/// The 'ConcreteIterator' class
/// </summary>

public class ConcreteIterator : IIterator
{
    ConcreteAggregate aggregate;
    int _current = 0;

    // Constructor

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }

    // Gets first iteration item

    public override object First()
    {
        return aggregate[0];
    }

    // Gets next iteration item

    public override object Next()
    {
        object ret = null;
        if (_current < aggregate.Count - 1)
        {
            ret = aggregate[++_current];
        }

        return ret;
    }

    // Gets current iteration item

    public override object CurrentItem()
    {
        return aggregate[_current];
    }

    // Gets whether iterations are complete

    public override bool IsDone()
    {
        return _current >= aggregate.Count;
    }
}