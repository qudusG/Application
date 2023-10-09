using Application.Core.Dtos.Educations;
using Application.Core.Dtos.Experiences;
using Application.Core.Dtos.MultiChoiceQuestions;
using Application.Core.Dtos.Questions;
using Application.Core.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Dtos.Forms;

public record AddFormArgs
{
    [Required]
    public Guid ProgramId { get; set; }

    [Required]
    public IFormFile Image { get; set; } = default!;

    [Required]
    public string FirstName { get; set; } = default!;

    [Required]
    public string LastName { get; set; } = default!;

    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Phone { get; set; }

    [Required]
    public string? IDNumber { get; set; }

    [Required]
    public string? Residence { get; set; }

    [Required]
    public string? Gender { get; set; }

    [Required]
    public DateTime? BirthDate { get; set; }
    public List<AddQuestionArgs> Questions { get; set; } = new();
    public List<AddMultiChoiceQuestionArgs> MultiChoiceQuestions { get; set; } = new();
    public List<AddEducationArgs> Educations { get; set; } = new();
    public List<AddExperienceArgs> Experiences { get; set; } = new();
}