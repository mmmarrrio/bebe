namespace UniversityEF;


public class TestModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsRepeatable { get; set; } = false;
    public Enums.TestType Type { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset PublishedAt { get; set; }
    public DateTimeOffset Deadline { get; set; }
    public int? DurationMinutes { get; set; }
    public bool IsPublic { get; set; } = false;
    public int? PassingScrore { get; set; }
    public int? MaxAttempts { get; set; }
    public List<QuestionModel> Questions { get; set; }
    public List<StudentModel> Students { get; set; }
    public List<ProjectModel> Projects { get; set; }
    public List<CourseModel> Courses { get; set; }
    public List<GroupModel> Groups { get; set; }
    public List<DirectionModel> Directions { get; set; }
    public List<AttemptModel> Attempts { get; set; }            // ! Почему этого нет в ТЗ?
    public List<TestResultModel> TestResults { get; set; }      // ! Почему этого нет в ТЗ?
}