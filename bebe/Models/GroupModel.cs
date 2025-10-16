namespace UniversityEF;


public class GroupModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DirectionId { get; set; }
    public int CourseId { get; set; }
    public int ProjectId { get; set; }
    public DirectionModel Direction { get; set; }
    public CourseModel Course { get; set; }
    public ProjectModel Project { get; set; }
    public List<StudentModel> Students { get; set; }
    public List<TestModel> Tests { get; set; }
}