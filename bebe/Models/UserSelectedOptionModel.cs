namespace UniversityEF;


public class UserSelectedOptionModel
{
    public int Id { get; set; }
    public int UserAttemptAnswerId { get; set; }
    public int AnswerId { get; set; }
    public UserAttemptAnswerModel UserAttemptAnswer { get; set; }
    public AnswerModel Answer { get; set; }
}