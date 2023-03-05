//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/using-async-for-file-access
//https://h-savran.blogspot.com/2019/12/using-bulk-operations-of-azure-cosmos.html
using Cosmos_DB_Bulk_ItemDetail;
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
    public static class BulkItemPatch
    {
        public static async Task BulkTransactionUpdate()
        {
            //await LoadItemsToUpdate();
            Stopwatch watch = Stopwatch.StartNew();
            var options = new CosmosClientOptions() { AllowBulkExecution = true };
            var cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, options);
            Database database = cosmosClient.GetDatabase(Program.DatabaseName);
            Microsoft.Azure.Cosmos.Container container = database.GetContainer(Program.ContainerName);
            try
            {
                //var cmd = "select * from c where c.statuscode = @sc";
                QueryDefinition query = new QueryDefinition("select * from c where c.statuscode = @sc")
                    .WithParameter("@sc", "1");
                var queryResultSetIterator = container.GetItemQueryIterator<Item_POCO>(query);
                List<Item_POCO> items_list = new List<Item_POCO>();
                try
                {
                    //changed to if, instead of while
                    while (queryResultSetIterator.HasMoreResults)
                    {
                        FeedResponse<Item_POCO> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                        foreach (Item_POCO current in currentResultSet)
                        {
                            items_list.Add(current);
                        }
                    }
                    Console.WriteLine("Number of Items : " + items_list.Count);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    //return null;
                }
                //Prepare items for insertion
                Console.WriteLine("Preparing items to update");
                List<Task> concurrentTasks = new List<Task>();
                foreach (Item_POCO itemtoUpdate in items_list)
                {
                    var tsk = container.PatchItemAsync<Item_POCO>(
                        id: itemtoUpdate.EventID,
                        partitionKey: new PartitionKey(itemtoUpdate.partitionKey),
                        patchOperations: new[] { PatchOperation.Replace("/statuscode", "2") });
                    concurrentTasks.Add(tsk);
                }
                await Task.WhenAll(concurrentTasks);
                watch.Stop();
                TimeSpan ts = watch.Elapsed;
                Console.WriteLine($"The time it took to execute this bulk patch: {ts}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
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