namespace SalesWeb.Models
{
    public class Departament
    {
        public Departament() { }
        public Departament(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public  string  Name { get; set; }
        public  ICollection<Seller> Sellers { get; set; }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime start, DateTime end)
        {
            return Sellers.Sum(s => s.TotalSales(start, end));
        }
    }
}
