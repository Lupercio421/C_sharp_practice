using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk
{
    public class CosmosDBSingletonClient
    {
        private static object synclock = new object();
        private static CosmosDBSingletonClient instance = new CosmosDBSingletonClient();
        private readonly CosmosClient _client;

        private CosmosDBSingletonClient()
        {
            var connectionString = "";
            var clientOptions = new CosmosClientOptions()
            {
                AllowBulkExecution = true,
            };
            _client = new CosmosClient(connectionString, clientOptions);
        }

        public static CosmosDBSingletonClient Instance
        {
            get
            {
                lock (synclock)
                {
                    if (CosmosDBSingletonClient.instance == null)
                    {
                        CosmosDBSingletonClient.instance = new CosmosDBSingletonClient();
                    }
                    return CosmosDBSingletonClient.instance;
                }
            }
        }
        public CosmosClient Client
        { 
            get 
            { 
                return _client;
            }
        }
    }
}
