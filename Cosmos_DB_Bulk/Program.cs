using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Cosmos_DB_Bulk;
//using Microsoft.Azure.Cosmos;
using CosmosDBBulk;
using Microsoft.Azure.Cosmos;
using CosmosMassUpdate;

public class Program
{
    public const string DatabaseName = "bulk-tutorial";
    public const string ContainerName = "items";
    public const int AmountToInsert = 10000;

    static async Task Main()
    {
        //await BulkCreation.BulkTransactionCreation();
        //await BulkItemPatch.BulkTransactionUpdate();
        await BulkItemPatch.LoadItemsToUpdate();
    }

    private static async Task<List<itempoco>> LoadItemsToUpdate()
    {
        CosmosClient cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, new CosmosClientOptions() { AllowBulkExecution = true });
        Database database = cosmosClient.GetDatabase(Program.DatabaseName);
        Microsoft.Azure.Cosmos.Container container = database.GetContainer(Program.ContainerName);
        var cmd = "select * from c where c.statuscode = \"3\"";
        QueryDefinition query = new QueryDefinition(cmd);
        var queryResultSetIterator = container.GetItemQueryIterator<itempoco>(query);

        List<Program.itempoco> items_list = new List<Program.itempoco>();
        try
        {
            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<itempoco> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach (itempoco current in currentResultSet)
                {
                    items_list.Add(current);
                }
            }
            Console.WriteLine("Number of Items : " + items_list.Count);
            return items_list;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            return null;
        }
    }

    private static async Task<bool> BulkTransactionUpdate(List<itempoco> item_list)
    {
        await LoadItemsToUpdate();
        try
        {
            var options = new CosmosClientOptions() { AllowBulkExecution = true };
            var cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, options);
            var container = cosmosClient.GetContainer("bulk-tutorial", "Posts");
            //posts.ForEach(t => t.Tags = "Update tags");
            Stopwatch watch = Stopwatch.StartNew();
            List<Task> concurrentTasks = new List<Task>();
            foreach (itempoco itemtoUpdate in item_list)
            {
                //tasks.Add(container.CreateItemAsync(item, new PartitionKey(item.partitionKey)
                var tsk = container.PatchItemAsync<itempoco>(
                        id: itemtoUpdate.id,
                        partitionKey: new PartitionKey(itemtoUpdate.partitionKey),
                        patchOperations: new[] { PatchOperation.Replace("/statuscode", "4") });
                concurrentTasks.Add(tsk);
            }
            await Task.WhenAll(concurrentTasks);
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            Console.WriteLine($"The time it took to execute this bulk patch: {ts}");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
            return false;
        }

    }
    public class itempoco
    {
        public string id { get; set; }
        public string partitionKey { get; set; }
        public string username { get; set; }

    }
    private static IReadOnlyCollection<itempoco> GetItemsToInsert()
    {
        return new Bogus.Faker<itempoco>()
            .StrictMode(true)
            //Generate item
            .RuleFor(o => o.id, f => Guid.NewGuid().ToString()) //id
            .RuleFor(o => o.username, f => f.Internet.UserName())
            .RuleFor(o => o.partitionKey, (f, o) => o.id) //partitionkey
            .Generate(AmountToInsert);
    }
}