using Application.Core.Enums;

namespace Application.Core.Models;

public class Program : BaseModel
{
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public string? Summary { get; set; }
    public string? Benefits { get; set; }
    public string? Criteria { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ApplicationOpeningDate { get; set; }
    public DateTime ApplicationClosingDate { get; set; }
    public int DurationInMonths { get; set; }
    public string? Location { get; set; }
    public bool IsRemote { get; set; }
    public ProgramType ProgramType { get; set; }
    public MinimumQualification MinimumQualification { get; set; }
    public int MaximumNumberOfApplications { get; set; }
    public List<ProgramSkill> ProgramSkills { get; set; } = new();
}