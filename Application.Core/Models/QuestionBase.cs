namespace Application.Core.Models;

public class QuestionBase : BaseModel
{
    public Guid FormId { get; set; }
    public Form Form { get; set; } = default!;
}
