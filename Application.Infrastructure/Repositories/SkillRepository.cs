using Application.Core.Models;
using Application.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Application.Infrastructure.Repositories;

public class SkillRepository : RepositoryBase<Skill>, ISkillRepository
{
    public SkillRepository(IConfiguration configuration) : base(configuration)
    {
    }
}