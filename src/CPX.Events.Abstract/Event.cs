namespace CPX.Events.Abstract;

public abstract class Event
{
    protected Event(string aggregateId, int version, DateTime createdAt)
    {
        AggregateId = aggregateId;
        Version = version;
        CreatedAt = createdAt;
    }

    public string AggregateId { get; }
    public int Version { get; }
    public DateTime CreatedAt { get; }
}