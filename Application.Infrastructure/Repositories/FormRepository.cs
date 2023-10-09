using Application.Core.Models;
using Application.Core.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Application.Infrastructure.Repositories;

public class FormRepository : RepositoryBase<Form>, IFormRepository
{
    public FormRepository(IConfiguration configuration) : base(configuration)
    {
    }
}