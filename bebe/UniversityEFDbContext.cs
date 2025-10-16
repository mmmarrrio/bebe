using Microsoft.EntityFrameworkCore;

namespace UniversityEF;


public class UniversityEFDbContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }
    public DbSet<StudentModel> Students { get; set; }
    public DbSet<GroupModel> Groups { get; set; }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<ProjectModel> Projects { get; set; }
    public DbSet<DirectionModel> Directions { get; set; }
    public DbSet<TestModel> Tests { get; set; }
    public DbSet<QuestionModel> Questions { get; set; }
    public DbSet<AnswerModel> Answers { get; set; }
    public DbSet<AttemptModel> Attempts { get; set; }
    public DbSet<UserAttemptAnswerModel> UserAttemptAnswers { get; set; }
    public DbSet<UserSelectedOptionModel> UserSelectedOptions { get; set; }
    public DbSet<UserTextAnswerModel> UserTextAnswers { get; set; }
    public DbSet<TestResultModel> TestResults { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserModelConfig());
        modelBuilder.ApplyConfiguration(new StudentModelConfig());
        modelBuilder.ApplyConfiguration(new GroupModelConfig());
        modelBuilder.ApplyConfiguration(new CourseModelConfig());
        modelBuilder.ApplyConfiguration(new ProjectModelConfig());
        modelBuilder.ApplyConfiguration(new DirectionModelConfig());
        modelBuilder.ApplyConfiguration(new TestModelConfig());
        modelBuilder.ApplyConfiguration(new QuestionModelConfig());
        modelBuilder.ApplyConfiguration(new AnswerModelConfig());
        modelBuilder.ApplyConfiguration(new AttemptModelConfig());
        modelBuilder.ApplyConfiguration(new UserAttemptAnswerModelConfig());
        modelBuilder.ApplyConfiguration(new UserSelectedOptionModelConfig());
        modelBuilder.ApplyConfiguration(new UserTextAnswerModelConfig());
        modelBuilder.ApplyConfiguration(new TestResultModelConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=123");
    }
}