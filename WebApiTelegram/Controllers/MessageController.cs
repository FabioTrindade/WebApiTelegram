using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Net;
using System.Text;
using WebApiTelegram.Model;

namespace WebApiTelegram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly string urlBase;
        private readonly string token;
        private readonly string chatId;

        public MessageController (IOptions<ConfigurationModel> config)
        {
            urlBase = config.Value.UrlBase;
            token = config.Value.BotToken;
            chatId = config.Value.ChatId;
        }

        [HttpPost]
        public void Send([FromBody] string message)
        {
            string text = message;

            string url = String.Format(urlBase, token, chatId, text);

            WebRequest request = WebRequest.Create(url);
            Stream stream = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            string line = "";
            StringBuilder sb = new StringBuilder();

            while (line != null)
            {
                line = reader.ReadLine();

                if (line != null)
                {
                    sb.Append(line);
                    ResponseModel response = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(line);
                }
            }
            //string response = sb.ToString();
        }
    }
}