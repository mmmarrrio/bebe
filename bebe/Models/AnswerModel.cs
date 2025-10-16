namespace UniversityEF;


public class AnswerModel
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    public int QuestionId { get; set; }
    public QuestionModel Question { get; set; }
    public List<UserSelectedOptionModel> UserSelectedOptions { get; set; }
}