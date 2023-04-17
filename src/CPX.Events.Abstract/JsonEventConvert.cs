namespace CPX.Events.Abstract;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public static class JsonEventConvert
{
    public static string Serialize(Event @event)
    {
        return JsonConvert.SerializeObject(@event, new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            Culture = CultureInfo.InvariantCulture
        });
    }

    public static TEvent? Deserialize<TEvent>(string value) where TEvent : Event
    {
        var @object = Deserialize(value, typeof(TEvent));
        return @object as TEvent;
    }

    public static object? Deserialize(string value, Type type)
    {
        var eventType = typeof(Event);

        if (eventType.IsAssignableFrom(type).Equals(false))
            throw new ArgumentException("The provided type does not extend the Event class.");

        var @event = JsonConvert.DeserializeObject(value, type);

        if (@event is null)
            return null;

        return @event;
    }
}