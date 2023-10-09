using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.Experiences;

public record AddExperienceArgs
{
    [Required]
    public string Company { get; set; } = default!;

    [Required]
    public string Title { get; set; } = default!;

    [Required]
    public string Location { get; set; } = default!;

    [Required]
    public DateTime StartDate { get; set; } = default!;

    [Required]
    public DateTime EndDate { get; set; } = default!;
}