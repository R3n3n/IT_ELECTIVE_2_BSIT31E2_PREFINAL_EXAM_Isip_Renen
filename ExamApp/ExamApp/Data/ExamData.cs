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
            new QuestionAnswer {
                Number = 3,
                Topic = "EF Core Basics",
                Question = "What is the primary purpose of Entity Framework Core?",
                Options = new Dictionary<string, string> { { "A", "To create HTML pages automatically" }, { "B", "To replace the MVC Controller" }, { "C", "To map objects in code to relational database data" }, { "D", "To replace the C# compiler" } },
                CorrectLetter = "C"
            },
            new QuestionAnswer {
                Number = 4,
                Topic = "EF Core Basics",
                Question = "Which EF Core component is primarily responsible for communicating with the database?",
                Options = new Dictionary<string, string> { { "A", "DbContext" }, { "B", "DbSetView" }, { "C", "ControllerContext" }, { "D", "RazorContext" } },
                CorrectLetter = "A"
            },
            new QuestionAnswer {
                Number = 5,
                Topic = "EF Core Basics",
                Question = "What does the command \"dotnet ef dbcontext scaffold \\\"ConnectionString\\\" Microsoft.EntityFrameworkCore.SqlServer -o Models\" primarily do?",
                Options = new Dictionary<string, string> { { "A", "Deletes the database" }, { "B", "Creates a new MVC project" }, { "C", "Generates EF Core models and a DbContext from an existing database" }, { "D", "Starts the MVC application" } },
                CorrectLetter = "C"
            },
            new QuestionAnswer {
                Number = 6,
                Topic = "Relational Data Modeling",
                Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Options = new Dictionary<string, string> { { "A", "Program.cs only" }, { "B", "appsettings.json" }, { "C", "Index.cshtml" }, { "D", "Student.cs" } },
                CorrectLetter = "B"
            },
            new QuestionAnswer {
                Number = 7,
                Topic = "Relational Data Modeling",
                Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Options = new Dictionary<string, string> { { "A", "One-to-One" }, { "B", "One-to-Many" }, { "C", "Many-to-Many" }, { "D", "Many-to-One only" } },
                CorrectLetter = "B"
            },
            new QuestionAnswer {
                Number = 8,
                Topic = "Relational Data Modeling",
                Question = "In the example \"public int SectionId { get; set; } / public Section Section { get; set; }\", what is SectionId?",
                Options = new Dictionary<string, string> { { "A", "Primary key of Student" }, { "B", "Foreign key referencing Section" }, { "C", "Navigation property" }, { "D", "Database connection string" } },
                CorrectLetter = "B"
            },
            new QuestionAnswer {
                Number = 9,
                Topic = "Conceptual Data Architecture",
                Question = "What is the purpose of a navigation property such as \"public Section Section { get; set; }\"?",
                Options = new Dictionary<string, string> { { "A", "It stores the database password" }, { "B", "It represents a relationship to another entity" }, { "C", "It creates a new database" }, { "D", "It validates the student's name" } },
                CorrectLetter = "B"
            },
        };
    }
}