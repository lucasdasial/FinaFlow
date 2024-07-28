namespace SalesWeb.Models
{
    public class Seller
    {
        public Seller() { }
        public Seller(string name, string email, DateTime birthDate, double salary, Departament departament)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Departament = departament;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public void AddSales(SalesRecord record)
        {
            Sales.Add(record);
        }

        public void RemoveSales(SalesRecord record)
        {
            Sales.Remove(record);
        }

        public double TotalSales(DateTime start, DateTime end)
        {
            return Sales
                .Where(s => s.Date >= start && s.Date <= end)
                .Sum(s => s.amount);
        }
    }
}
