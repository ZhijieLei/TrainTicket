using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TrainService.NetworkData.Query
{
    [JsonObject(MemberSerialization.OptIn)]
    public class QueryResponse
    {
        [JsonIgnore]
        public string ValidateMessagesShowId { get; set; }

        [JsonProperty(PropertyName = "status")]
        public bool Status { get; set; }

        [JsonProperty(PropertyName = "httpstatus")]
        public int HttpStatus { get; set; }

        [JsonProperty(PropertyName = "data")]
        public TrainDataItem Data { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public IEnumerable<string> Messages { get; set; }

        [JsonIgnore]
        public IEnumerable<JObject> ValidateMessages { get; set; }
    }
}