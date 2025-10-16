namespace UniversityEF;


public class TestResultModel
{
    public int Id { get; set; }
    public bool Passed { get; set; }
    public int TestId { get; set; }
    public int AttemptId { get; set; }
    public int StudentId { get; set; }
    public TestModel Test { get; set; }
    public AttemptModel Attempt { get; set; }
    public StudentModel Student { get; set; }
}