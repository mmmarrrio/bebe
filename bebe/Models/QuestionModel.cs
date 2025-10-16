namespace UniversityEF;


public class QuestionModel
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int Number { get; set; }
    public string? Description { get; set; }
    public Enums.AnswerType AnswerType { get; set; }
    public bool IsScoring { get; set; } = true;
    public int? MaxScore { get; set; }
    public int TestId { get; set; }
    public TestModel Test { get; set; }
    public List<UserAttemptAnswerModel> UserAttemptAnswers { get; set; }
    public List<AnswerModel> Answers { get; set; }
}