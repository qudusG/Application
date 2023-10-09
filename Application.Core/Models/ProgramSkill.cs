namespace Application.Core.Models;

public class ProgramSkill
{
    public Guid Id { get; set; }
    public Guid ProgramId { get; set; }
    public Program Program { get; set; } = default!;
    public Guid SkillId { get; set; } = default!;
    public Skill Skill { get; set; } = default!;
}