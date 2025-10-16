namespace UniversityEF;


public class UserTextAnswerModel
{
    public int Id { get; set; }
    public string TextAnswer { get; set; }
    public int UserAttemptAnswerId { get; set; }
    public UserAttemptAnswerModel UserAttemptAnswer { get; set; }
    
}