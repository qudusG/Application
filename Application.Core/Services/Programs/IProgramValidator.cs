using Application.Core.Dtos.Programs;

namespace Application.Core.Services.Programs;

public interface IProgramValidator
{
    Task AddValidateAsync(AddProgramArgs args);
}