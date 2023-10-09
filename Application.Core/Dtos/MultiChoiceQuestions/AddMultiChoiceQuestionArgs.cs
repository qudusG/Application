using Application.Core.Dtos.Choices;
using Application.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.MultiChoiceQuestions;

public record AddMultiChoiceQuestionArgs
{
    [Required]
    public ChoiceQuestionType QuestionType { get; set; }

    public List<AddChoiceArgs> Choices { get; set; } = new();
}