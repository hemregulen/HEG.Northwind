

using Newtonsoft.Json;

namespace HEG.Northwind.Service.Northwind.Model
{
    public class Customers 
    {
        [JsonProperty("customerID")]
        public string? CustomerID { get; set; }
        [JsonProperty("companyName")]
        public string? CompanyName { get; set; }
        [JsonProperty("contactName")]
        public string? ContactName { get; set; }
        [JsonProperty("contactTitle")]
        public string? ContactTitle { get; set; }
        [JsonProperty("address")]
        public string? Address { get; set; }
        [JsonProperty("city")]
        public string? City { get; set; }
        [JsonProperty("region")]
        public string? Region { get; set; }
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }
        [JsonProperty("country")]
        public string? Country { get; set; }
        [JsonProperty("phone")]
        public string? Phone { get; set; }
        [JsonProperty("fax")]
        public string? Fax { get; set; }
    }
}
