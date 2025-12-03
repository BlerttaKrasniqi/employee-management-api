using EmployeeManagement.Api.Data;
using EmployeeManagement.Api.Dtos;
using EmployeeManagement.Api.Mappings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public EmployeesController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmployeeResponseDto>>> GetEmployees()
    {
        var employees = await _dbContext.Employees.ToListAsync();
        var result = employees.Select(EmployeeMapper.ToResponseDto).ToList();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<EmployeeResponseDto>> GetEmployee(int id)
    {
        var employee = await _dbContext.Employees.FindAsync(id);
        if (employee == null)
            return NotFound();

        var dto = EmployeeMapper.ToResponseDto(employee);
        return Ok(dto);
    }

    [HttpPost]
    public async Task<ActionResult<EmployeeResponseDto>> CreateEmployee([FromBody] EmployeeRequestDto requestDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var employee = EmployeeMapper.FromRequestDto(requestDto);
        _dbContext.Employees.Add(employee);
        await _dbContext.SaveChangesAsync();

        var response = EmployeeMapper.ToResponseDto(employee);
        return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, response);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeRequestDto requestDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var employee = await _dbContext.Employees.FindAsync(id);
        if (employee == null)
            return NotFound();

        employee.FirstName = requestDto.FirstName;
        employee.LastName = requestDto.LastName;
        employee.DateOfBirth = requestDto.DateOfBirth;
        employee.EducationLevel = requestDto.EducationLevel;

        await _dbContext.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var employee = await _dbContext.Employees.FindAsync(id);
        if (employee == null)
            return NotFound();

        _dbContext.Employees.Remove(employee);
        await _dbContext.SaveChangesAsync();
        return NoContent();
    }
}
