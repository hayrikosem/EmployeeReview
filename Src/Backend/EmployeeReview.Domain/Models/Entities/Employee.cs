using EmployeeReview.Domain.Models.Common;
using EmployeeReview.Domain.Models.Dtos;

namespace EmployeeReview.Domain.Models.Entities;

public class Employee : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime HireDate { get; set; }
    public string JobTitle { get; set; }
    public int? ManagerId { get; set; }
    public virtual Employee Manager { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public Employee UpdateFromDto(EmployeeDto dto)
    {
        // Update fields with values from the DTO
        FirstName = dto.FirstName;
        LastName = dto.LastName;
        Email = dto.Email;
        HireDate = dto.HireDate;
        JobTitle = dto.JobTitle;
        ManagerId = dto.ManagerId;

        return this;
    }
}