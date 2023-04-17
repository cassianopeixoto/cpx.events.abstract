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
        var @event = JsonConvert.DeserializeObject<TEvent>(value);

        if (@event is null)
            return null;

        return @event;
    }
}