namespace UniversityEF;


public class AttemptModel
{
    public int Id { get; set; }
    public DateTimeOffset StartedAt { get; set; }
    public DateTimeOffset? SubmittedAt { get; set; }
    public int? Score { get; set; }
    public int TestId { get; set; }
    public int StudentId { get; set; }
    public TestModel Test { get; set; }
    public StudentModel Student { get; set; }
    public List<UserAttemptAnswerModel> UserAttemptAnswers { get; set; }
    public List<TestResultModel> TestResults { get; set; }      // ! Почему этого нет в ТЗ?
}