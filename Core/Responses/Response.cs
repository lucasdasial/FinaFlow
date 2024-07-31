using System.Text.Json.Serialization;

namespace Core.Responses
{
    public abstract class Response<T>
    {
        [JsonConstructor]
        public Response()
        {
            Message = null;
            _code = Config.DefaultStatusCode;
        }

        public Response(
            T? data,
            int code = Config.DefaultStatusCode,
            string? message = null)
        {
            Data = data;
            Message = message;
            _code = code;
        }
        private readonly int _code = Config.DefaultStatusCode;

        public string? Message { get; set; }
        public T? Data { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}