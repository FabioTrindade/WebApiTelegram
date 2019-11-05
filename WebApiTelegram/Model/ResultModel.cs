using Newtonsoft.Json;
using System;

namespace WebApiTelegram.Model
{
    public class ResultModel
    {
        [JsonProperty("message_id")]
        public Int64 MessageId { get; set; }

        [JsonProperty("chat")]
        public ChatModel Chat { get; set; }

        [JsonProperty("date")]
        public Int64 Date { get; set; }

        [JsonProperty("text")]
        public String Text { get; set; }
    }
}
