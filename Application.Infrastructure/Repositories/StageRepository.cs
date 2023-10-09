using Application.Core.Models;
using Application.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Application.Infrastructure.Repositories;

public class StageRepository : RepositoryBase<Stage>, IStageRepository
{
    public StageRepository(IConfiguration configuration) : base(configuration)
    {
    }
}