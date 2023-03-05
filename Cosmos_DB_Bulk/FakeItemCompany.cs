using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk
{
    public class FakeItemCompany
    {
        [JsonProperty("id")]
        public string? EventId { get; set; }
        public string? partitionKey { get; set; }
        public string? company { get; set; }
        public int? ttl { get; set; }
    }
}
