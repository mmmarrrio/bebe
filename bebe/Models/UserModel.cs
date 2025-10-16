using System.ComponentModel.DataAnnotations;
namespace UniversityEF;

public class UserModel
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public Enums.UserRole? Role { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public StudentModel? Student { get; set; }
}