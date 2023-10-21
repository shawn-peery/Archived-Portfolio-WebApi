using Microsoft.Graph;
using Newtonsoft.Json;

namespace Portfolio_WebApi.Models.ResponseModels
{
    public class ReturnModelWithMessageDto<T>
    {

        [JsonProperty(nameof(Message))]
        public string Message { get; set; }

        [JsonProperty(nameof(Model))]
        public T Model { get; set; }

        public ReturnModelWithMessageDto(string Message, T Model)
        {
            this.Message = Message;
            this.Model = Model;
        }
    }
}