using Application.Core.Dtos.Programs;
using Application.Core.Models;

namespace Application.Core.Services.Programs;

public interface IProgramService
{
    Task<Guid> AddAsync(AddProgramArgs programArgs);
}
