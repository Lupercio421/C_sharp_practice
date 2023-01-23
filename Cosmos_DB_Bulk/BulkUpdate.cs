using ItemDetail;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosMassUpdate
{
    public class BulkCreation
    {
        public static async Task BulkTransactionUpdate()
        {
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

        }
        private static async Task<IReadOnlyCollection<Item>> GetItemsToInsert()
        {
            CosmosClient cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, new CosmosClientOptions() { AllowBulkExecution = true });
            Database database = cosmosClient.GetDatabase(Program.DatabaseName);
            Microsoft.Azure.Cosmos.Container container = database.GetContainer(Program.ContainerName);

            QueryDefinition query = new QueryDefinition(
                "select * from c where c.statuscode = @sc")
                .WithParameter("@sc", "3");
            List<Item> items = new List<Item>();
            using (FeedIterator<Item> resultSet = container.GetItemQueryIterator<Item>(
                query,
                requestOptions: new QueryRequestOptions()
                {
                    PartitionKey = new PartitionKey("partitionKey")
                }))
            {
                while (resultSet.HasMoreResults)
                {
                    FeedResponse<Item> response = await items.Add(resultSet.ReadNextAsync());
                }
            }
                return items;
        }


    }
}
