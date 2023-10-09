using Application.Core.Dtos.Exceptions;
using Application.Core.Dtos.Programs;
using Application.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Application.Core.Services.Programs;

public class ProgramValidator : IProgramValidator
{
    private readonly ISkillRepository _skillRepository;
    public ProgramValidator(ISkillRepository skillRepository)
    {
        _skillRepository = skillRepository;
    }

    public async Task AddValidateAsync(AddProgramArgs args)
    {
        foreach(var skill in args.ProgramSkills)
        {
            if (await _skillRepository.GetItemAsync(skill.SkillId) == null)
                throw new RequestException(StatusCodes.Status400BadRequest, "One of the specified skills do not exist.");
        }
    }
}