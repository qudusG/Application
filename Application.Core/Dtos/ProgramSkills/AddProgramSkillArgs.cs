namespace Application.Core.Dtos.ProgramSkills;

public record AddProgramSkillArgs
{
    public Guid SkillId { get; set; } = default!;
}