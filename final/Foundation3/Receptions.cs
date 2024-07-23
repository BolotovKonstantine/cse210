public class Receptions : Event
{
    private string _host;
    private bool _isFormal;

    public Receptions(string title, string description, string date, string time,
        Address address, string host, bool isFormal)
        : base(title, description, date, time, address)
    {
        _host = host;
        _isFormal = isFormal;
    }


    public string DisplayFullDetails()
    {
        var baseDetails = base.DisplayStdDetails();
        var receptionDetails = $"\nHost: {_host}\nFormal: {_isFormal}";
        return baseDetails + receptionDetails;
    }
}