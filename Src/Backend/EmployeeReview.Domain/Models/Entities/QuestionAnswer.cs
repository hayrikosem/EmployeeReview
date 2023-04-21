using EmployeeReview.Domain.Models.Common;

namespace EmployeeReview.Domain.Models.Entities;

public class QuestionAnswer : BaseEntity
{
    public string AnswerText { get; set; }
    public int ReviewQuestionId { get; set; }
    public virtual ReviewQuestion ReviewQuestion { get; set; }
    public int ReviewId { get; set; }
    public virtual Review Review { get; set; }
}
