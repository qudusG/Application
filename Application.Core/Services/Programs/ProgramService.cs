using Application.Core.Dtos.Programs;
using Application.Core.Models;
using Application.Core.Repositories.Interfaces;

namespace Application.Core.Services.Programs;

public class ProgramService : IProgramService
{
    private readonly IProgramRepository _programRepository;
    private readonly IProgramValidator _programValidator;
    public ProgramService(IProgramRepository programRepository, IProgramValidator programValidator)
    {
        _programRepository = programRepository;
        _programValidator = programValidator;
    }

    public async Task<Guid> AddAsync(AddProgramArgs args)
    {
        await _programValidator.AddValidateAsync(args);

        var program = new Program
        {
            Title = args.Title,
            Description = args.Description,
            Summary = args.Summary,
            Benefits = args.Benefits,
            Criteria = args.Criteria,
            StartDate = args.StartDate!.Value,
            EndDate = args.EndDate!.Value,
            ApplicationOpeningDate = args.ApplicationOpeningDate!.Value,
            ApplicationClosingDate = args.ApplicationClosingDate!.Value,
            DurationInMonths = args.DurationInMonths!.Value,
            Location = args.Location,
            IsRemote = args.IsRemote,
            ProgramType = args.ProgramType!.Value
        };

        program = await _programRepository.CreateItemAsync(program);

        return program.Id;
    }
}