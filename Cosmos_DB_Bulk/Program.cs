using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Cosmos_DB_Bulk;
//using Microsoft.Azure.Cosmos;
using CosmosDBBulk;
using Microsoft.Azure.Cosmos;
using CosmosMassUpdate;
using QueryWorkspace;
using Bogus.DataSets;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public const string DatabaseName = "bogus-data";
    public const string ContainerName = "items";
    public const int AmountToInsert = 2;

    static async Task Main()
    {
        //await BulkCreation.BulkTransactionCreation();
        //await BulkItemPatch.BulkTransactionUpdate();
        //await BulkItemPatch.LoadItemsToUpdate();
        //await ReadMany.QueryManyItemsAsync();
        //await MIDField.MIDGenerator();

    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCosmosRepository(
            options =>
            {
                options.CosmosConnectionString = _ConnectionString;
                options.ContainerId = ContainerName;
                options.DatabaseId = DatabaseName;
                options.OptimizeBandwidth = false;
                options.AllowBulkExecution = true;
            });
        //services.AddSingleton();
    }
}