using Application.Core.Enums;

namespace Application.Core.Models
{
    public class Stage : BaseModel
    {
        public string Name { get; set; } = default!;
        public StageType StageType { get; set; } = default!;
    }
}