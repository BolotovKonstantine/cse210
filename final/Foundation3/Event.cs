public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    
public Event(string title, string description, string date, string time, Address address)
{
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
}

public string DisplayStdDetails()
{
    string _details = $"Title: {_title}\nDescription: {_description}\n" +
                  $"Date: {_date}\nTime: {_time}\n" +
                  $"Address:\n{_address.DisplayAddress()}";
    return _details;
}
public string ShortDescription()
{
    var typeOfEvent = GetType().Name;
    var details = $"{typeOfEvent} - Title: {_title}, Date: {_date}";
    return details;
}
}