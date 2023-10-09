using Application.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.Stages;

public record AddStageArgs
{
    [Required]
    public string Name { get; set; } = default!;

    [Required]
    public StageType StageType { get; set; } = default!;
}