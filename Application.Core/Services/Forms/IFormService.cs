using Application.Core.Dtos.Forms;
using Application.Core.Models;

namespace Application.Core.Services.Forms;

public interface IFormService
{
    Task<Form> AddAsync(AddFormArgs formArgs);
}
