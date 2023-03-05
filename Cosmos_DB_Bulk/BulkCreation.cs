using Cosmos_DB_Bulk_ItemDetail;
using Microsoft.Azure.Cosmos;
using System.Diagnostics;

namespace CosmosDBBulk
{
    public class BulkCreation
    {
        public static async Task BulkTransactionCreation()
        {
            
            CosmosClient cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, new CosmosClientOptions() { AllowBulkExecution = true });
            Database database = cosmosClient.GetDatabase(Program.DatabaseName);
            try
            {
                // Prepare items for insertion
                Console.WriteLine($"Preparing {Program.AmountToInsert} items to insert...");
                // <Operations>
                IReadOnlyCollection<Item_POCO> itemsToInsert = GetItemsToInsert();
                // </Operations>

                // Create the list of Tasks
                Console.WriteLine($"Starting...");
                Stopwatch stopwatch = Stopwatch.StartNew();
                // <ConcurrentTasks>
                Container container = database.GetContainer(Program.ContainerName);
                List<Task> tasks = new List<Task>(Program.AmountToInsert);
                foreach (var item in itemsToInsert)
                {
                    tasks.Add(container.CreateItemAsync<Item_POCO>(item, new PartitionKey(item.partitionKey))
                        .ContinueWith(itemResponse =>
                        {
                            if (!itemResponse.IsCompletedSuccessfully)
                            {
                                AggregateException innerExceptions = itemResponse.Exception.Flatten();
                                 if (innerExceptions.InnerExceptions.FirstOrDefault(innerEx => innerEx is CosmosException) is CosmosException cosmosException)
                                {
                                    Console.WriteLine($"Received {cosmosException.StatusCode} ({cosmosException.Message}).");
                                }
                                else
                                {
                                    Console.WriteLine($"Exception {innerExceptions.InnerExceptions.FirstOrDefault()}.");
                                }
                            }
                        }));
                }

                // Wait until all are done
                await Task.WhenAll(tasks);
                // </ConcurrentTasks>
                stopwatch.Stop();

                Console.WriteLine($"Finished in writing {Program.AmountToInsert} items in {stopwatch.Elapsed}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Cleaning up resources...");
                //await database.DeleteAsync();
            }

        }

        private static IReadOnlyCollection<Item_POCO> GetItemsToInsert()
        {
            return new Bogus.Faker<Item_POCO>()
                .StrictMode(true)
                //Generate item
                .RuleFor(o => o.EventID, f => Guid.NewGuid().ToString()) //id
                .RuleFor(o => o.username, f => f.Internet.UserName())
                .RuleFor(o => o.partitionKey, f => Guid.NewGuid().ToString()) //id
                .RuleFor(o => o.vehicle_manufacturer, f => f.Vehicle.Manufacturer())
                .RuleFor(o => o.vehicle_model, f => f.Vehicle.Model())
                .RuleFor(o => o.company, f => f.Company.CompanyName())
                .RuleFor(o => o.statuscode, f => f.Random.Int(min : 1, max: 5).ToString())
                .Generate(Program.AmountToInsert);
        }

    }
}
