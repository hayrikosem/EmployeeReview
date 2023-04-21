namespace EmployeeReview.Domain.Models.Dtos
{
    public class EmployeeDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public string JobTitle { get; set; }
        public int? ManagerId { get; set; }
    }
}