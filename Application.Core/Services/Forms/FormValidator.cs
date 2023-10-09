using Application.Core.Dtos.Exceptions;
using Application.Core.Dtos.Forms;
using Application.Core.Dtos.Programs;
using Application.Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Application.Core.Services.Forms;

public class FormValidator : IFormValidator
{
    public FormValidator()
    {
    }

    public async Task AddValidateAsync(AddFormArgs args)
    {
    }
}