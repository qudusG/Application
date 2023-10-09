using Application.Core.Dtos.Forms;

namespace Application.Core.Services.Forms;

public interface IFormValidator
{
    Task AddValidateAsync(AddFormArgs args);
}