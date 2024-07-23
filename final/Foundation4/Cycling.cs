public class Cycling : Activity
{
    private double _speed; // in kilometers per hour

    public Cycling(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _duration) / 60; // distance = speed * time, and convert it to kilometers
    }

    public override string GetSummary()
    {
        return base.GetSummary().Replace("Activity", "Cycling");
    }
}