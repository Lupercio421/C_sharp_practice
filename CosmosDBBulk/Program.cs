using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using CosmosDBBulk;

public class Program
{
    public const string EndpointUrl = "https://2531665f-0ee0-4-231-b9ee.documents.azure.com:443/";
    public const string AuthorizationKey = "GEoooUcKE1hw34Hi7ua2UjG6mV3DsPYAwa0FBd7GrL2NeM72QD5LQ3RqfMis96GOMD2KUw4KumNcACDbThUKCw==";
    public const string DatabaseName = "bulk-tutorial";
    public const string ContainerName = "items";
    public const int AmountToInsert = 30000;

    static async Task Main()
    {
        await BulkCreation.BulkTransactionCreation();
    }
    public class Item
    {
        public string id { get; set; }
        public string partitionKey { get; set; }
        public string username { get; set; }

    }
    private static IReadOnlyCollection<Item> GetItemsToInsert()
    {
        return new Bogus.Faker<Item>()
            .StrictMode(true)
            //Generate item
            .RuleFor(o => o.id, f => Guid.NewGuid().ToString()) //id
            .RuleFor(o => o.username, f => f.Internet.UserName())
            .RuleFor(o => o.partitionKey, (f, o) => o.id) //partitionkey
            .Generate(AmountToInsert);
    }
}