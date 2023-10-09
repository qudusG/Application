namespace Application.Core.Dtos.Choices;

public record AddChoiceArgs
{
    public string Text { get; set; } = default!;
}