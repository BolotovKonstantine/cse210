public abstract class Activity
{
    protected DateTime _date;
    protected double _duration;

    public Activity(DateTime date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0; // no distance in generic activity
    }

    public double GetSpeed()
    {
        return (this.GetDistance() / _duration) * 60; // speed = distance/time, and convert it to per hour
    }

    public double GetPace()
    {
        return _duration / this.GetDistance(); // pace = time/distance
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}