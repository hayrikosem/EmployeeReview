using Application.Interfaces.Services;
using EmployeeReview.Domain.Models.Dtos;
using EmployeeReview.Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
    {
        var employees = await _employeeService.GetAllAsync();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetEmployee(int id)
    {
        var employee = await _employeeService.GetByIdAsync(id);

        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPost]
    public async Task<ActionResult<Employee>> CreateEmployee(EmployeeDto employeeCreateDto)
    {
        var entity = new Employee().UpdateFromDto(employeeCreateDto);

        await _employeeService.CreateAsync(entity);

        return CreatedAtAction(nameof(GetEmployee), new { id = entity.Id }, employeeCreateDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, EmployeeDto employeeUpdateDto)
    {
        var entity =await _employeeService.GetByIdAsync(id);
        entity.UpdateFromDto(employeeUpdateDto);
         await _employeeService.UpdateAsync(entity);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        await _employeeService.DeleteAsync(id);

        return NoContent();
    }
}