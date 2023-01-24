using ItemDetail;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace CosmosMassUpdate
{
    public class BulkItemPatch
    {
        public static async Task<bool> BulkTransactionUpdate(List<itempoco> item_list)
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
                        patchOperations: new[] { PatchOperation.Replace("/statuscode", "4")});
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
        public static async Task<List<itempoco>> LoadItemsToUpdate()
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


    }
}
//CosmosClient cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, new CosmosClientOptions() { AllowBulkExecution = true });
//Database database = cosmosClient.GetDatabase(Program.DatabaseName);
//try
//{
//    // Prepare items for insertion
//    Console.WriteLine($"Preparing {Program.AmountToInsert} items to insert...");

//    // <Operations>
//    IReadOnlyCollection<Item> itemsToInsert = GetItemsToInsert();
//    // </Operations>

//    // Create the list of Tasks
//    Console.WriteLine($"Starting...");
//    Stopwatch stopwatch = Stopwatch.StartNew();
//    // <ConcurrentTasks>
//    Container container = database.GetContainer(Program.ContainerName);
//    List<Task> tasks = new List<Task>(Program.AmountToInsert);
//    foreach (Item item in itemsToInsert)
//    {
//        tasks.Add(container.CreateItemAsync(item, new PartitionKey(item.partitionKey))
//            .ContinueWith(itemResponse =>
//            {
//                if (!itemResponse.IsCompletedSuccessfully)
//                {
//                    AggregateException innerExceptions = itemResponse.Exception.Flatten();
//                    if (innerExceptions.InnerExceptions.FirstOrDefault(innerEx => innerEx is CosmosException) is CosmosException cosmosException)
//                    {
//                        Console.WriteLine($"Received {cosmosException.StatusCode} ({cosmosException.Message}).");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Exception {innerExceptions.InnerExceptions.FirstOrDefault()}.");
//                    }
//                }
//            }));
//    }

//    // Wait until all are done
//    await Task.WhenAll(tasks);
//    // </ConcurrentTasks>
//    stopwatch.Stop();

//    Console.WriteLine($"Finished updating {Program.AmountToInsert} items in {stopwatch.Elapsed}.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//}
//finally
//{
//    Console.WriteLine("Cleaning up resources...");
//    //await database.DeleteAsync();
//}
//using (FeedIterator<Item> resultSet = container.GetItemQueryIterator<Item>(
//    query,
//    requestOptions: new QueryRequestOptions()
//    {
//        PartitionKey = new PartitionKey("partitionKey")
//    }))
//{
//    while (resultSet.HasMoreResults)
//    {
//        FeedResponse<Item> response = await items.Add(resultSet.ReadNextAsync());
//    }
//}
//    return items;