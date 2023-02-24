using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace PaystackSdk.Core.Transactions.Responses
{
    public class InitializeTransactionResponse
    {
        [JsonProperty("authorization_url")]
        public string AuthorizationUrl { get; set; } = default!;

        [JsonProperty("access_code")]
        public string AccessCode { get; set; } = default!;

        [JsonProperty("reference")]
        public string Reference { get; set; } = default!;
    }
}
