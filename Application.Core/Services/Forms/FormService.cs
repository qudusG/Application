using Application.Core.Dtos.Forms;
using Application.Core.Models;
using Application.Core.Repositories.Interfaces;

namespace Application.Core.Services.Forms;

public class FormService : IFormService
{
    private readonly IFormRepository _formRepository;
    private readonly IFormValidator _formValidator;
    public FormService(IFormRepository formRepository, IFormValidator formValidator)
    {
        _formRepository = formRepository;
        _formValidator = formValidator;
    }

    public async Task<Form> AddAsync(AddFormArgs formArgs)
    {
        Form form = new()
        {
            // TODO: Store the image file name or URL as needed
            Image = formArgs.Image.FileName,
            FirstName = formArgs.FirstName,
            LastName = formArgs.LastName,
            Email = formArgs.Email,
            Phone = formArgs.Phone,
            IDNumber = formArgs.IDNumber,
            Residence = formArgs.Residence,
            Gender = formArgs.Gender,
            BirthDate = formArgs.BirthDate,
            ProgramId = formArgs.ProgramId,

            Questions = formArgs.Questions.Select(q => new Question
            {
                QuestionType = q.QuestionType!.Value
            }).ToList(),

            MultiChoiceQuestions = formArgs.MultiChoiceQuestions.Select(mcq => new MultiChoiceQuestion
            {
                QuestionType = mcq.QuestionType,
                Choices = mcq.Choices.Select(c => new Choice { Text = c.Text }).ToList()
            }).ToList(),

            Educations = formArgs.Educations.Select(education => new Education
            {
                StartDate = education.StartDate,
                Location = education.Location,
                EndDate = education.EndDate,
                Course = education.Course,
                Degree = education.Degree,
                School = education.School
            }).ToList(),

            Experiences = formArgs.Experiences.Select(experience => new Experience
            {
                Company = experience.Company,
                EndDate = experience.EndDate,
                Location = experience.Location,
                StartDate = experience.StartDate,
                Title = experience.Title
            }).ToList()
        };

        await _formRepository.CreateItemAsync(form);

        return form;
    }
}