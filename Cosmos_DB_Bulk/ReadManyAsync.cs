using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos_DB_Bulk_ItemDetail;
using Microsoft.Azure.Cosmos;

namespace QueryWorkspace
{
    public class ReadMany
    {
        public static async Task QueryManyItemsAsync()
        {
            CosmosClient cosmosClient = new CosmosClient(Program.EndpointUrl, Program.AuthorizationKey, new CosmosClientOptions() { AllowBulkExecution = true });
            Database database = cosmosClient.GetDatabase(Program.DatabaseName);
            Microsoft.Azure.Cosmos.Container container = database.GetContainer(Program.ContainerName);
            QueryDefinition query = new QueryDefinition("select * from c where c.statuscode = @sc")
                .WithParameter("@sc", "3");
            var queryResultSetIterator = container.GetItemQueryIterator<Item_POCO>(query);
            List<Item_POCO> items_list = new List<Item_POCO>();
            try
            {
                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<Item_POCO> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (Item_POCO current in currentResultSet)
                    {
                        items_list.Add(current);
                        //Console.WriteLine($"Item ID: {current.id} and status code: {current.statuscode}");
                    }
                }
                Console.WriteLine("Number of Items : " + items_list.Count);
                //return items_list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                //return null;
            }


        }
    }
}
