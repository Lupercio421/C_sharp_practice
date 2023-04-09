using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk
{
    public class CosmosDBSingleton
    {
        //private static CosmosDBSingleton instance = null;
        private static object syncLock = new object();
        private static readonly Lazy<CosmosDBSingleton> lazy = new Lazy<CosmosDBSingleton>(() => new CosmosDBSingleton());
        private static CosmosClient client;
        private static readonly string endpointURL = "";
        private static readonly string primaryKey = "";
        private static readonly string connectionString = "";
        
        private CosmosDBSingleton() 
        {
            CosmosClientOptions cosmosClientOptions = new CosmosClientOptions()
            {
                AllowBulkExecution = true,
            };
            client = new CosmosClient(connectionString, cosmosClientOptions);
        }
        public static CosmosDBSingleton Instance
        {
            get
            {
                //lock (syncLock)
                //{
                //    if (CosmosDBSingleton.instance == null)
                //    {
                //        CosmosDBSingleton.instance = new CosmosDBSingleton();
                //    }
                //    return CosmosDBSingleton.instance;
                //}
                if (lazy.IsValueCreated)
                {
                    return lazy.Value;
                }
                lock (syncLock)
                {
                    if (!lazy.IsValueCreated)
                    {
                        lazy.Value = new CosmosDBSingleton();
                    }
                }
                return lazy.Value;

            }
            //{ 
            //    return instance; 
            //} 
        }
    }
}
