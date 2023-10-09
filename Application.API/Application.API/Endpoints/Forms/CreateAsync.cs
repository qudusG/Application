using Application.Core.Dtos.Forms;
using Application.Core.Services.Forms;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Endpoints.Forms;

/// <summary>
/// Represents an asynchronous endpoint for creating application forms.
/// </summary>
public class CreateAsync : EndpointBaseAsync
    .WithRequest<AddFormArgs>
    .WithResult<ActionResult<Guid>>
{
    private readonly IFormService _formService;

    public CreateAsync(IFormService formService)
    {
        _formService = formService;
    }

    [HttpPost("api/Forms")]
    public override async Task<ActionResult<Guid>> HandleAsync(
      AddFormArgs args, CancellationToken cancellationToken = default)
    {
        return Ok(await _formService.AddAsync(args));
    }
}