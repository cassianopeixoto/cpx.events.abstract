namespace CPX.Events.Abstract.Test;

public class EventTest
{
    [Fact]
    public void Should_be_able_to_create()
    {
        // Arrange
        var id = "id";
        var version = 1;
        var createdAt = DateTimeOffset.Now;
        // Act
        var mockEvent = new Mock<Event>(id, version, createdAt);
        var @event = mockEvent.Object;
        // Assert
        Assert.Equal(id, @event.Id);
        Assert.Equal(version, @event.Version);
        Assert.Equal(createdAt, @event.CreatedAt);
    }
}