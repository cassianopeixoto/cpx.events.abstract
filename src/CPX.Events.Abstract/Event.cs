namespace CPX.Events.Abstract;

public abstract class Event
{
    protected Event(string id, int version, DateTimeOffset createdAt)
    {
        Id = id;
        Version = version;
        CreatedAt = createdAt;
    }

    public string Id { get; }
    public int Version { get; }
    public DateTimeOffset CreatedAt { get; }
}