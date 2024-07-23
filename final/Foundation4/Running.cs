public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    
    public override string GetSummary()
    {
        string baseSummary = base.GetSummary();
        return baseSummary.Replace("Activity", "Running");
    }
}