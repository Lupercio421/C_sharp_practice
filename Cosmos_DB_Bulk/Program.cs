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
using ItemDetail;
using QueryWorkspace;
using Bogus.DataSets;

public class Program
{
    public const string DatabaseName = "bulk-tutorial";
    public const string ContainerName = "items";
    public const int AmountToInsert = 20;

    static async Task Main()
    {
        //await BulkCreation.BulkTransactionCreation();
        await BulkItemPatch.BulkTransactionUpdate();
        //await BulkItemPatch.LoadItemsToUpdate();
        //await ReadMany.QueryManyItemsAsync();
    }

    //private static IReadOnlyCollection<Item_poco> GetItemsToInsert()
    //{
    //    return new Bogus.Faker<Item_poco>()
    //        .StrictMode(true)
    //        //Generate item
    //        .RuleFor(o => o.id, f => Guid.NewGuid().ToString()) //id
    //        .RuleFor(o => o.username, f => f.Internet.UserName())
    //        .RuleFor(o => o.partitionKey, f => Guid.NewGuid().ToString()) //id
    //        .RuleFor(o => o.vehicle_manufacturer, f => f.Vehicle.Manufacturer())
    //        .RuleFor(o => o.vehicle_model, f => f.Vehicle.Model())
    //        .RuleFor(o => o.company, f => f.Company.CompanyName())
    //        .RuleFor(o => o.hashids, f => f.Hashids.ToString())
    //        //.RuleFor(o => o.partitionKey, (f, o) => o.id) //partitionkey
    //        .Generate(AmountToInsert);
    //}
}