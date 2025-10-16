namespace UniversityEF;


public class UserAttemptAnswerModel
{
    public int Id { get; set; }
    public bool? isCorrect { get; set; }
    public int? ScoreAwarded { get; set; }
    public int AttemptId { get; set; }
    public int QuestionId { get; set; }
    public AttemptModel Attempt { get; set; }
    public QuestionModel Question { get; set; }
    public List<UserSelectedOptionModel>? UserSelectedOptions { get; set; }
    public UserTextAnswerModel? UserTextAnswer { get; set; }
}