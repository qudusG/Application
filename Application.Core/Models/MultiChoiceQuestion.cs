using Application.Core.Enums;

namespace Application.Core.Models;

public class MultiChoiceQuestion : QuestionBase
{
    public ChoiceQuestionType QuestionType { get; set; }
    public List<Choice> Choices { get; set; } = new();
}