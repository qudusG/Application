namespace Application.Core.Models;

public class Form : BaseModel
{
    public string Image { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? IDNumber { get; set; }
    public string? Residence { get; set; }
    public string? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public Guid ProgramId { get; set; }
    public Program Program { get; set; } = default!;
    public List<Question> Questions { get; set; } = new();
    public List<MultiChoiceQuestion> MultiChoiceQuestions { get; set; } = new();
    public List<Education> Educations { get; set; } = new();
    public List<Experience> Experiences { get; set; } = new();
    public List<Stage> Stages { get; set; } = new();
    public List<VideoStage> VideoStages { get; set; } = new();
}