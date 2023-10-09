using Application.Core.Dtos.ProgramSkills;
using Application.Core.Enums;
using Application.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.Programs;

public record AddProgramArgs
{
    [Required]
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public string? Summary { get; set; }
    public string? Benefits { get; set; }
    public string? Criteria { get; set; }

    [Required]
    public DateTime? StartDate { get; set; }

    [Required]
    public DateTime? EndDate { get; set; }

    [Required]
    public DateTime? ApplicationOpeningDate { get; set; }

    [Required]
    public DateTime? ApplicationClosingDate { get; set; }

    [Required]
    public int? DurationInMonths { get; set; }
    public string? Location { get; set; }
    public bool IsRemote { get; set; }

    [Required]
    public ProgramType? ProgramType { get; set; }

    public List<AddProgramSkillArgs> ProgramSkills { get; set; } = new();
}