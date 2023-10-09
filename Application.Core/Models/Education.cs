namespace Application.Core.Models;

public class Education : BaseModel
{
    public string School { get; set; } = default!;
    public string Degree { get; set; } = default!;
    public string Course { get; set; } = default!;
    public string Location { get; set; } = default!;
    public DateTime StartDate { get; set; } = default!;
    public DateTime EndDate { get; set; } = default!;
}