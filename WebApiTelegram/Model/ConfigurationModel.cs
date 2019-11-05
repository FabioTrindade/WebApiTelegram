using System;

namespace WebApiTelegram.Model
{
    public class ConfigurationModel
    {
        public String UrlBase { get; set; }
        public String BotToken { get; set; }
        public String ChatId { get; set; }
    }
}
