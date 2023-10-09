using Application.Core.Dtos.Programs;
using Application.Core.Services.Programs;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Endpoints.Programs;

/// <summary>
/// Represents an asynchronous endpoint for creating programs.
/// </summary>
public class CreateAsync : EndpointBaseAsync
    .WithRequest<AddProgramArgs>
    .WithResult<ActionResult<Guid>>
{
    private readonly IProgramService _programService;

    public CreateAsync(IProgramService programService)
    {
        _programService = programService;
    }

    [HttpPost("api/Programs")]
    public override async Task<ActionResult<Guid>> HandleAsync(
      AddProgramArgs args, CancellationToken cancellationToken = default)
    {
        return Ok(await _programService.AddAsync(args));
    }
}