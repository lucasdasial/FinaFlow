using Core.Enums;

namespace Core.Models;

public class TransactionModel
{
    public long Id { get; set; }
    public decimal Amount { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? PaidOrReceivedAt { get; set; }
    public TransactionType Type { get; set; } = TransactionType.Withdraw;
    public string UserId { get; set; } = string.Empty;
    public long CategoryId { get; set; }
    public CategoryModel Category { get; set; } = null!;
}
