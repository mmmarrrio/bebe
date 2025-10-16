using System.Text.RegularExpressions;

namespace UniversityEF;

public class StudentModel
{
    public int Id { get; set; }
    public string Phone { get; set; }
    public string VkProfileLink { get; set; }
    public int UserId { get; set; }
    public UserModel User { get; set; }
    public List<GroupModel> Groups { get; set; }
    public List<TestModel> Tests { get; set; }
    public List<AttemptModel> Attempts { get; set; }
    public List<TestResultModel> TestResults { get; set; }
}