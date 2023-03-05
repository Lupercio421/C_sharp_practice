using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk
{
    public class FakeItemStatus
    {
        [JsonProperty("id")]
        public string? EventId { get; set; }
        public string? partitionKey { get; set; }
        public string? statuscode { get; set; }
        public int? ttl { get; set; }

    }
}
