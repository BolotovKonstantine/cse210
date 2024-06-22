public static class PromptGenerator
{
    
    public static List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Write about the most interesting thing you experienced today.",
        "Describe someone you saw today who you found intriguing.",
        "Draw or describe the most delicious meal you had today.",
        "What conversation stood out to you the most today? Why?",
        "What was the high point and the low point of your day?",
        "What is one thing you learned today?",
        "Write about one thing that made you smile today.",
        "Did anything unexpected happen today? If so, how did you respond?",
        "How did you make a positive impact today?",
        "What is one thing you wish you had done differently today?",
        "What are you looking forward to tomorrow?",
        "Write about a moment when you felt grateful today.",
        "Describe the weather today and how it affected your mood.",
        "What is one question that came up for you today?",
        "Write a letter to your future self about your thoughts and feelings today?",
        
    };
    
    public static string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}