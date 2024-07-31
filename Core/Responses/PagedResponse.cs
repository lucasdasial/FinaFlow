using System.Text.Json.Serialization;

namespace Core.Responses
{
    public class PagedResponse<T> : Response<T>
    {

        [JsonConstructor]
        public PagedResponse(
            T? data,
            int totalCount,
            int currentPage = 1,
            int pageSize = Config.DefaultPageSize) : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse(T? data, string message, int code) : base(data, code, message)
        {

        }

        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)TotalPages);
        public int PageSize { get; set; } = Config.DefaultPageSize;
        public int TotalCount { get; set; }

    }
}