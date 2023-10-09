using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.Educations;

public record AddEducationArgs
{
    [Required]
    public string School { get; set; } = default!;

    [Required]
    public string Degree { get; set; } = default!;

    [Required]
    public string Course { get; set; } = default!;

    [Required]
    public string Location { get; set; } = default!;

    [Required]
    public DateTime StartDate { get; set; } = default!;

    [Required]
    public DateTime EndDate { get; set; } = default!;
}