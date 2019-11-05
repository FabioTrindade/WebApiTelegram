using Newtonsoft.Json;
using System;

namespace WebApiTelegram.Model
{
    public class ChatModel
    {
        [JsonProperty("id")]
        public Int64 Id { get; set; }

        [JsonProperty("title")]
        public String Title { get; set; }

        [JsonProperty("username")]
        public String Username { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }
    }
}
