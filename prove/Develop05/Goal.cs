public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _points = points;
        _description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public string GetDetailsString()
    {
        return $"Goal: {_shortName}\nDescription: {_description}\nPoints: {_points}";
    }
}