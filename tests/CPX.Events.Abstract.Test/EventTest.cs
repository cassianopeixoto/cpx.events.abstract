namespace CPX.Events.Abstract.Test;

public class EventTest
{
    [Fact]
    public void Should_be_able_to_create()
    {
        // Arrange
        var aggregateId = "aggregateId";
        var version = 1;
        var createdAt = DateTime.Now;
        // Act
        var mockEvent = new Mock<Event>(aggregateId, version, createdAt);
        var @event = mockEvent.Object;
        // Assert
        Assert.Equal(aggregateId, @event.AggregateId);
        Assert.Equal(version, @event.Version);
        Assert.Equal(createdAt, @event.CreatedAt);
    }
}