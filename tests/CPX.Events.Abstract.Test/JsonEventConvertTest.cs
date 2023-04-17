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
        var type = @event.GetType();
        // Act
        var @object = JsonEventConvert.Deserialize(serializedEvent, type);
        @event = @object as FooEvent;
        // Assert
        Assert.NotNull(@event);
        if (@event is not null)
            Assert.Equal(createdAt, @event.CreatedAt);
    }

    [Fact]
    public void Should_not_be_able_to_deserialize_when_the_object_is_not_an_event()
    {
        // Arrange
        var name = "foo";
        var foo = new Foo(name);
        var type = foo.GetType();
        var serialized = $"{{\"name\":\"{name}\"}}";
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() =>
        {
            JsonEventConvert.Deserialize(serialized, type);
        });
    }
}