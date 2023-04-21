using EmployeeReview.Domain.Models.Common;

namespace EmployeeReview.Domain.Models.Entities;

public class ReviewQuestion : BaseEntity
{
    public string Text { get; set; }
    public string Category { get; set; }
    public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
}