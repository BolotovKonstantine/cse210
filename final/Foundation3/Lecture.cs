public class Lecture : Event
{
    private string _speaker;
    private string _topic;

    public Lecture(string title, string description, string date, string time,
        Address address, string speaker, string topic)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _topic = topic;
    }
    
    public string DisplayFullDetails()
    {
        var baseDetails = base.DisplayStdDetails();
        var lectureDetails = $"\nSpeaker: {_speaker}\nTopic: {_topic}";
        return baseDetails + lectureDetails;
    }
}