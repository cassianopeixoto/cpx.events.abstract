namespace CPX.Events.Abstract.Test.Mocks;

public sealed class FooEvent : Event
{
    public FooEvent(DateTimeOffset createdAt) : base(createdAt)
    {
    }
}