namespace EmployeeManagement.Api.Models;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public string EducationLevel { get; set; } = null!;
}