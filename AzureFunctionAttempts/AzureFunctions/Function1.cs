using System;
using System.Collections.Generic;
using ItemDetail;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctions
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([CosmosDBTrigger(
            databaseName: "bulk-tutorial",
            containerName: "items",
            Connection = "DBConnectionString",
            CreateLeaseContainerIfNotExists = true,
            LeaseContainerName ="azure-function-leases",
            LeaseContainerPrefix = "container-change-")]IReadOnlyList<Item_poco> input,
            ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Documents modified " + input.Count);
                log.LogInformation("First document Id " + input[0].EventID);
            }
        }
    }
}
