using System;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace apiServices.Model
{

    public class Api1
    {
        public int id { get; set; }
        public string? Contact_Address { get; set; }
        public string? Warehouse_Address { get; set; }
        public string? dimension { get; set; }
    }



    public class Api2
    {
        public int id { get; set; }
        public string? Consignee { get; set; }
        public string? Consignor { get; set; }
        public string? Cartons { get; set; }
    }

    public class Api3
    {
        public int id { get; set; }
        public string? Source { get; set; }
        public string? Destination { get; set; }
        public string? Package { get; set; }
    }
}

