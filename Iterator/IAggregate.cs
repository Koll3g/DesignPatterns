namespace Iterator;

/// <summary>
/// The 'Aggregate' abstract class
/// </summary>

public abstract class IAggregate
{
    public abstract IIterator CreateIterator();
}