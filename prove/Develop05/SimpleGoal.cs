public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"S,{_shortName},{_description},{_points},{_isComplete}";
    }
}