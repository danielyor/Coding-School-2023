namespace FuelStation.Model
{
    public class Ledger
    {
        public Ledger() { }

        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
