
namespace Core.Requests
{
    public class PagedRequest : Request
    {
        public int PageSize { get; set; } = Config.DefaultPageSize;
        public int PageNumber { get; set; } = Config.DefaultPageNumber;
    }
}
