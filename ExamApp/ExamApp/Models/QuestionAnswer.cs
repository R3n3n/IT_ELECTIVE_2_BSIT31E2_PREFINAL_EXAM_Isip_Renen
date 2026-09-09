namespace ExamApp.Models
{
    public class QuestionAnswer
    {
        public int Number { get; set; }
        public string Topic { get; set; } = string.Empty;
        public string Question { get; set; } = string.Empty;
        public Dictionary<string, string> Options { get; set; } = new Dictionary<string, string>();
        public string CorrectLetter { get; set; } = string.Empty;
    }
}