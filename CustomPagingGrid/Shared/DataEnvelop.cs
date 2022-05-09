using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPagingGrid.Shared
{
#nullable disable
    public class DataEnvelop
    {
        //[JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        //[JsonProperty("@odata.count")]
        public int OdataCount { get; set; }

        [JsonProperty("value")]
        public List<Value> Value { get; set; }
    }

    public class Value
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("MiddleName")]
        public object MiddleName { get; set; }

        [JsonProperty("Gender")]
        public string Gender { get; set; }

        [JsonProperty("Age")]
        public object Age { get; set; }

        [JsonProperty("Emails")]
        public List<string> Emails { get; set; }

        [JsonProperty("FavoriteFeature")]
        public string FavoriteFeature { get; set; }

        [JsonProperty("Features")]
        public List<object> Features { get; set; }

        [JsonProperty("AddressInfo")]
        public List<AddressInfo> AddressInfo { get; set; }

        [JsonProperty("HomeAddress")]
        public object HomeAddress { get; set; }
    }

    public class City
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("CountryRegion")]
        public string CountryRegion { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }
    }

    public class AddressInfo
    {
        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("City")]
        public City City { get; set; }
    }
}
