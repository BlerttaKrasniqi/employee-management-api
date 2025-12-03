using EmployeeManagement.Api.Dtos;
using EmployeeManagement.Api.Models;

namespace EmployeeManagement.Api.Mappings;

public static class EmployeeMapper
{
    public static EmployeeResponseDto ToResponseDto(Employee employee)
    {
        var now = DateTime.UtcNow;
        var age = (int)((now - employee.DateOfBirth).TotalDays / 365.25);

        return new EmployeeResponseDto
        {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            DateOfBirth = employee.DateOfBirth,
            EducationLevel = employee.EducationLevel,
            Age = age
        };
    }

    public static Employee FromRequestDto(EmployeeRequestDto dto)
    {
        return new Employee
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            DateOfBirth = dto.DateOfBirth,
            EducationLevel = dto.EducationLevel
        };
    }
}