using Application.Core.Enums;

namespace Application.Core.Models;

public class Question : QuestionBase
{
    public QuestionType QuestionType { get; set; }
}