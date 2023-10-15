using Microsoft.Graph;

namespace Portfolio_WebApi.Models.ResponseModels {
    public class ReturnModelWithMessageDto<T> {
        public string Message = string.Empty;
        public T Model;

        public ReturnModelWithMessageDto(string Message, T Model ) {
            this.Message= Message;
            this.Model = Model;
        }
    }
} 