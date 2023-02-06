using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CosmosDBFx
{
    public static class ContainerChange
    {
        private static readonly string _endpointUrl = System.Environment.GetEnvironmentVariable("cosmos-endpointUrl");
        private static readonly string _primaryKey = System.Environment.GetEnvironmentVariable("cosmos-primaryKey");
        private static readonly string _changeDBId = "bulk-tutorial";
        private static readonly string _changecontainerId = "items-vehicles-moved";
        private static CosmosClient cosmosClient = new CosmosClient(_endpointUrl,_primaryKey);
        
        [FunctionName("ContainerChange")]
        public static async Task Run([CosmosDBTrigger(
            databaseName: "bulk-tutorial",
            collectionName: "items",
            ConnectionStringSetting = "DBConnectionString",
            LeaseCollectionName = "item-leases")]IReadOnlyList<Document> input,
            ILogger log)
        {
            var container2 = cosmosClient.GetContainer(_changeDBId, _changecontainerId);
            if (input != null && input.Count > 0)
            {
                foreach (Document doc in input)
                {
                    log.LogInformation("Documents modified " + input.Count);
                    var _sc = doc.GetPropertyValue<string>("statuscode");
                    log.LogInformation("Document Status Code: " + _sc);
                    try
                    {
                        await container2.CreateItemAsync(doc);
                    }
                    catch (Exception ex) 
                    {
                        log.LogInformation("Exception pushing the document into container 2:" + ex.Message);
                    }

                }
            }
        }
    }
}
