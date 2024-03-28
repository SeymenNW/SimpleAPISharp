using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleAPISharp.API.Models.F1API
{
    public class MRDataDriverInfo
    {
        [JsonPropertyName("xmlns")]
        public string Xmlns { get; set; }

        [JsonPropertyName("series")]
        public string Series { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("limit")]
        public string Limit { get; set; }

        [JsonPropertyName("offset")]
        public string Offset { get; set; }

        [JsonPropertyName("total")]
        public string Total { get; set; }

        [JsonPropertyName("DriverTable")]
        public DriverTable DriverTable { get; set; }
    }

    public class DriverInfoTable
    {
        [JsonPropertyName("driverId")]
        public string DriverId { get; set; }

        [JsonPropertyName("Drivers")]
        public List<Driver> Drivers { get; set; }
    }

    public class DriverInfo
    {
        [JsonPropertyName("driverId")]
        public string DriverId { get; set; }

        [JsonPropertyName("permanentNumber")]
        public string PermanentNumber { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }

        [JsonPropertyName("familyName")]
        public string FamilyName { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }
    }

    public class F1RootDriverInfo
    {
        [JsonPropertyName("MRData")]
        public MRData MRData { get; set; }
    }
}
