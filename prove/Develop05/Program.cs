// For eceeding requirments I added user clas that keeps score in filesystem depending on username

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}