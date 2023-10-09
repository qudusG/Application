using Application.Core.Models;
using Application.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Application.Infrastructure.Repositories;

public class ProgramRepository : RepositoryBase<Program>, IProgramRepository
{
    public ProgramRepository(IConfiguration configuration) : base(configuration)
    {
    }
}