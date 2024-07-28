namespace SalesWeb.Models
{
    public class SalesRecord
    {
        public SalesRecord() { }
        public SalesRecord(DateTime date, double amount, SalesStatus status, Seller saler)
        {
            Date = date;
            this.amount = amount;
            this.status = status;
            Saler = saler;
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double amount { get; set; }
        public SalesStatus status { get; set; }
        public Seller Saler { get; set; }
    }
}
