namespace CPX.Events.Abstract.Test;

public class EventTest
{
    [Fact]
    public void Should_be_able_to_create()
    {
        // Arrange
        var createdAt = DateTimeOffset.Now;
        // Act
        var mockEvent = new Mock<Event>(createdAt);
        var @event = mockEvent.Object;
        // Assert
        Assert.Equal(createdAt, @event.CreatedAt);
    }
}