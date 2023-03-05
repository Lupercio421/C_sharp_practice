using Cosmos_DB_Bulk_ItemDetail;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk
{
    public class SinglePatch
    {

        public static async Task PatchSingleJson()
        {
            CosmosClient cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, new CosmosClientOptions() { AllowBulkExecution = true });
            Database database = cosmosClient.GetDatabase(Program.DatabaseName);
            Container container = database.GetContainer(Program.ContainerName);

            Console.WriteLine("\n1.6 - Patching a item using its Id");

            ItemResponse<Item_POCO> response = await container.PatchItemAsync<Item_POCO>(
                id: "7864afb5-14a0-4549-a8eb-dcc40e06b3b7",
                partitionKey: new PartitionKey("7864afb5-14a0-4549-a8eb-dcc40e06b3b7"),
                patchOperations: new[] { PatchOperation.Replace("/username", "Danny") });

            Item_POCO updatedItem = response.Resource;
            Console.WriteLine($"Username of updated item: {updatedItem.username}");
        }
    }
}
