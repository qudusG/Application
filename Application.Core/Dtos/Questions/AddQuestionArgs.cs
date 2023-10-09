using Application.Core.Dtos.Choices;
using Application.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.Questions;

public record AddQuestionArgs
{
    [Required]
    public QuestionType? QuestionType { get; set; }
}