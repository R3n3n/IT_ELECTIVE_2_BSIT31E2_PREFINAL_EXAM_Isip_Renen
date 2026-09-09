using ExamApp.Models;

namespace ExamApp.Data
{
    public static class ExamData
    {
        public static List<QuestionAnswer> Questions = new List<QuestionAnswer>
        {
            new QuestionAnswer {
                Number = 1,
                Topic = "Databases & Persistence",
                Question = "What is the main problem solved by using a database instead of an in-memory collection?",
                Options = new Dictionary<string, string> { { "A", "It makes C# code shorter" }, { "B", "It prevents the application from restarting" }, { "C", "It allows data to persist after the application stops" }, { "D", "It removes the need for MVC" } },
                CorrectLetter = "C"
            },
            new QuestionAnswer {
                Number = 2,
                Topic = "EF Core Basics",
                Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Options = new Dictionary<string, string> { { "A", "Code-First" }, { "B", "Database-First" }, { "C", "Model-First" }, { "D", "Controller-First" } },
                CorrectLetter = "B"
            },
        };
    }
}