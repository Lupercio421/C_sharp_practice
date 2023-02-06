using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDetail
{
    public class Item_poco
    {
        public string id { get; set; }
        public string partitionKey { get; set; }
        public string username { get; set; }
        public string statuscode { get; set; }
        public string? company { get; set; }
        public string? vehicle_manufacturer { get; set; }
        public string? vehicle_model { get; set; }
        public string? hashids { get; set; }

    }
}
