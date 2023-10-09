namespace Application.Core.Models;

public class Choice : BaseModel
{
    public Guid QuestionId { get; set; }
    public Question Question { get; set; } = default!;
    public string Text { get; set; } = default!;
}