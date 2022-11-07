using Newtonsoft.Json;

namespace HEG.Northwind.Service.Northwind.Model
{
    public class Orders
    {
        [JsonProperty("orderID")]
        public int OrderID { get; set; }

        [JsonProperty("customerID")]
        public string? CustomerID { get; set; }

        [JsonProperty("employeeID")]
        public int? EmployeeID { get; set; }

        [JsonProperty("orderDate")]
        public DateTime? OrderDate { get; set; }

        [JsonProperty("requiredDate")]
        public DateTime? RequiredDate { get; set; }

        [JsonProperty("shippedDate")]
        public DateTime? ShippedDate { get; set; }

        [JsonProperty("shipVia")]
        public int? ShipVia { get; set; }

        [JsonProperty("freight")]
        public decimal? Freight { get; set; }

        [JsonProperty("shipName")]
        public string? ShipName { get; set; }

        [JsonProperty("shipAddress")]
        public string? ShipAddress { get; set; }

        [JsonProperty("shipCity")]
        public string? ShipCity { get; set; }

        [JsonProperty("shipRegion")]
        public string? ShipRegion { get; set; }

        [JsonProperty("shipPostalCode")]
        public string? ShipPostalCode { get; set; }

        [JsonProperty("shipCountry")]
        public string? ShipCountry { get; set; }
    }
}
