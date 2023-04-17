using CPX.Events.Abstract.Test.Mocks;

namespace CPX.Events.Abstract.Test;

public sealed class JsonEventConvertTest
{
    [Fact]
    public void Should_be_able_to_serialize()
    {
        // Arrange
        var createdAt = new DateTimeOffset(new DateTime(2023, 4, 17));
        var @event = new FooEvent(createdAt);
        // Act
        var serializedEvent = JsonEventConvert.Serialize(@event);
        // Assert
        Assert.Equal("{\"createdAt\":\"2023-04-17T00:00:00+01:00\"}", serializedEvent);
    }

    [Fact]
    public void Should_be_able_to_deserialize()
    {
        // Arrange
        var createdAt = new DateTimeOffset(new DateTime(2023, 4, 17));
        var @event = new FooEvent(createdAt);
        var serializedEvent = JsonEventConvert.Serialize(@event);
        // Act
        @event = JsonEventConvert.Deserialize<FooEvent>(serializedEvent);
        // Assert
        Assert.NotNull(@event);
        if (@event is not null)
            Assert.Equal(createdAt, @event.CreatedAt);
    }
}