using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk_ItemDetail
{
    internal class Item_POCO
    {
        [JsonProperty("id")]
        public string? EventID { get; set; }
        public string? partitionKey { get; set; }
        public string? username { get; set; }
        public string? statuscode { get; set; }
        public string? company { get; set; }
        public string? vehicle_manufacturer { get; set; }
        public string? vehicle_model { get; set; }
        //public int? ttl { get; set; }

    }
}
//using Newtonsoft.Json;
//using Newtonsoft.Json.Serialization;

//namespace ItemDetail
//{
//    public class Item_poco
//    {
//        [JsonProperty("id")]
//        public string? EventID { get; set; }
//        public string? partitionKey { get; set; }
//        public string? username { get; set; }
//        public string? statuscode { get; set; }
//        public string? company { get; set; }
//        public string? vehicle_manufacturer { get; set; }
//        public string? vehicle_model { get; set; }
//        //public string? hashids { get; set; }
//        //public string? MID { get; set; }
//        public int? ttl { get; set; }

//    }
//}
