using Core.Models;
using Core.Requests.Categories;
using Core.Requests.Transactions;
using Core.Responses;

namespace Core.Handlers
{
    public interface ITransactionHandler
    {
        Task<Response<TransactionModel?>> CreateAsync(CreateTransactionRequest req);
        Task<Response<TransactionModel?>> DeleteAsync(DeleteTransactionRequest req);
        Task<Response<TransactionModel?>> UpdateAsync(UpdateTransactionRequest req);
        Task<Response<TransactionModel?>> GetByIdAsync(GetTransactionByIdRequest req);
        Task<PagedResponse<List<TransactionModel>?>> GetAllAsync(GetTransactionByPeriodRequest req);
    }
}
