namespace Iterator;

/// <summary>
/// The 'Iterator' abstract class
/// </summary>

public abstract class IIterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}