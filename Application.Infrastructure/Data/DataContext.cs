using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace Application.Infrastructure.Data;

public class DataContext : IDataContext
{
    private readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task InitializeAsync()
    {
        string endpointUri = _configuration.GetSection("EndPointUri").Value!;
        string primaryKey = _configuration.GetSection("PrimaryKey").Value!;
        CosmosClient cosmosClient = new (endpointUri, primaryKey, new CosmosClientOptions() { ApplicationName = "CosmosDBDotnetQuickstart" });
        Database database = cosmosClient.CreateDatabaseIfNotExistsAsync("db").Result;
        Container container = database.CreateContainerIfNotExistsAsync("items", "/LastName", 400).Result;
        await ScaleContainerAsync(container);
    }

    private async static Task ScaleContainerAsync(Container container)
    {
        // Read the current throughput
        int? throughput = await container.ReadThroughputAsync();
        if (throughput.HasValue)
        {
            Console.WriteLine("Current provisioned throughput : {0}\n", throughput.Value);
            int newThroughput = throughput.Value + 100;
            // Update throughput
            await container.ReplaceThroughputAsync(newThroughput);
            Console.WriteLine("New provisioned throughput : {0}\n", newThroughput);
        }
    }
}