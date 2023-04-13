namespace CPX.Events.Abstract;

public abstract class Event
{
    protected Event(DateTimeOffset createdAt)
    {
        CreatedAt = createdAt;
    }

    public DateTimeOffset CreatedAt { get; }
}