using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemDetail;
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
            var queryResultSetIterator = container.GetItemQueryIterator<Item_poco>(query);
            List<Item_poco> items_list = new List<Item_poco>();
            try
            {
                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<Item_poco> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    foreach (Item_poco current in currentResultSet)
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
