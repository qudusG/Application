using Application.Core.Dtos.Stages;
using Application.Core.Models;
using Application.Core.Repositories.Interfaces;

namespace Application.Core.Services.Workflows;

public class WorkFlowService : IWorkFlowService
{
    private readonly IStageRepository _stageRepository;
    public WorkFlowService(IStageRepository stageRepository)
    {
        _stageRepository = stageRepository;
    }

    public async Task<Stage> AddAsync(AddStageArgs args)
    {
        var stage = new Stage
        {
            Name = args.Name,
            StageType = args.StageType
        };

        stage = await _stageRepository.CreateItemAsync(stage);

        return stage;
    }
}