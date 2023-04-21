using EmployeeReview.Domain.Models.Common;

namespace EmployeeReview.Domain.Models.Entities;

public class Review : BaseEntity
{
    public DateTime Date { get; set; }
    public string ReviewerName { get; set; }
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
}