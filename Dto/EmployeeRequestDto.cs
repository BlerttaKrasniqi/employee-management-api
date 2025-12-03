using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Api.Dtos;

public class EmployeeRequestDto
{
    [Required]
    public string FirstName { get; set; } 

    [Required]
    public string LastName { get; set; } 

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string EducationLevel { get; set; } 
}