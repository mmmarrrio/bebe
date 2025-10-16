namespace UniversityEF;


public class ProjectModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<GroupModel> Groups { get; set; }
    public List<TestModel> Tests { get; set; }
}