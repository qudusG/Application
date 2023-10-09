using Application.Core.Models;
using Application.Core.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace Application.Infrastructure.Repositories;

public class RepositoryBase<TModel> : IRepositoryBase<TModel> where TModel : BaseModel
{
    private readonly Container _container;

    public RepositoryBase(IConfiguration configuration)
    {
        CosmosClient cosmosClient = new (configuration["CosmosDb:ConnectionString"]);
        _container = cosmosClient.GetContainer(configuration["CosmosDb:DatabaseId"], typeof(TModel).Name);
    }

    public async Task<TModel> GetItemAsync(Guid id)
    {
        var response = await _container.ReadItemAsync<TModel>(id.ToString(), new PartitionKey(id.ToString()));
        return response.Resource;
    }

    public async Task<TModel> CreateItemAsync(TModel item)
    {
        var response = await _container.CreateItemAsync(item, new PartitionKey(item.Id.ToString()));
        return response.Resource;
    }

    public async Task<TModel> UpdateItemAsync(TModel item)
    {
        var response = await _container.UpsertItemAsync(item, new PartitionKey(item.Id.ToString()));
        return response.Resource;
    }
}