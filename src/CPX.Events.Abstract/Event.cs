namespace CPX.Events.Abstract;

public abstract class Event
{
    protected Event(string id, int version, DateTime createdAt)
    {
        Id = id;
        Version = version;
        CreatedAt = createdAt;
    }

    public string Id { get; }
    public int Version { get; }
    public DateTime CreatedAt { get; }
}