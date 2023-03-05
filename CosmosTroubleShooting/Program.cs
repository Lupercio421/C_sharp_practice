// See https://aka.ms/new-console-template for more information
using CosmosTroubleShooting;

public class Program
{
    public const string EndpointUrl = "https://576f92cd-0ee0-4-231-b9ee.documents.azure.com:443/";
    public const string AuthorizationKey = "VmA0yv0cSE5lANHeVvDQIvo1QcJxMt22aA8bGPSYARRb8pljwx17H1miAASYKDkX9sqEN1Qeds62ACDbKP68vA==";
    public const string DatabaseName = "bogus-data";
    public const string ContainerName = "items";
    public const int AmountToInsert = 2;

    static async Task Main()
    {
        //
        await BulkCreate.BulkCreateAsync();
    }

}