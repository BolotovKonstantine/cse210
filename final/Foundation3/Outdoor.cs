public class Outdoor : Event
{
    private string _location;
    private string _weatherConditions;

    public Outdoor(string title, string description, string date, string time,
        Address address, string location, string weatherConditions)
        : base(title, description, date, time, address)
    {
        _location = location;
        _weatherConditions = weatherConditions;
    }

    public string DisplayFullDetails()
    {
        var baseDetails = base.DisplayStdDetails();
        var outdoorDetails = $"\nOutdoor location: {_location}\nWeather conditions: {_weatherConditions}";
        return baseDetails + outdoorDetails;
    }
}