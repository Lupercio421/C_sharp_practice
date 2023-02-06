using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CosmosDBFx
{
    public static class LogInfo
    {
        [Disable]
        [FunctionName("Log-Information-Function")]
        public static void Run([CosmosDBTrigger(
            databaseName: "bulk-tutorial",
            collectionName: "items",
            ConnectionStringSetting = "DBconnectionString",
            LeaseCollectionName = "item-leases",
            CreateLeaseCollectionIfNotExists = true)]IReadOnlyList<Document> input,
            ILogger log)
        {
            try 
            {
                if (input != null && input.Count > 0)
                {
                    foreach (Document _event in input) 
                    {
                        string json_id = _event.GetPropertyValue<string>("id");
                        string json_username = _event.GetPropertyValue<string>("username");
                        var json_company = _event.GetPropertyValue<string>("company");
                        log.LogInformation("Document Id " + json_id);
                        log.LogInformation($"Username: {json_username}");
                    }
                }
            }
            catch (Exception _ex) 
            {
                log.LogInformation("Error updating this document: " + _ex.Message);
                throw;
            }
            
            //if (input != null && input.Count > 0)
            //{
            //    log.LogInformation("Documents modified " + input.Count);
            //    log.LogInformation("First document Id " + input[0].Id);
            //}
        }
    }
}
