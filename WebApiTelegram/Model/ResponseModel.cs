using Newtonsoft.Json;

namespace WebApiTelegram.Model
{
    public class ResponseModel
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ResultModel Result { get; set; }
    }
}
