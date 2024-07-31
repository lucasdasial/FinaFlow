
namespace Core.Requests.Transactions
{
    public class GetTransactionByPeriodRequest : PagedRequest
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}