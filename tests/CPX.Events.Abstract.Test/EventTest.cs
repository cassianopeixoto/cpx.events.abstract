using CPX.Events.Abstract.Test.Mocks;

namespace CPX.Events.Abstract.Test;

public sealed class EventTest
{
    [Fact]
    public void Should_be_able_to_create()
    {
        // Arrange
        var createdAt = DateTimeOffset.Now;
        // Act
        var @event = new FooEvent(createdAt);
        // Assert
        Assert.Equal(createdAt, @event.CreatedAt);
    }
}