namespace Application.Core.Models;

public class VideoStage : BaseModel
{
    public string Name { get; set; } = default!;
    public string AdditionalDetails { get; set; } = default!;
    public int DurationInMinutes { get; set; }
    public int DeadlineInDays { get; set; }
}