namespace FuelStation.Model
{
    public class Customer
    {
        public Customer() { }

        public Customer(string name, string surname, string cardnum) {
            Name = name;
            Surname = surname;
            CardNumber = cardnum;   
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CardNumber { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; } = new();
    }
}
