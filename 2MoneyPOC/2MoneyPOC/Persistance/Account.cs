namespace _2MoneyPOC.Persistance;

public class Account
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Ammount { get; set; }
    public ICollection<Transaction> Transactions { get; set; }
}

public class Transaction
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public decimal Ammount { get; set; }
    public ICollection<Account> Accounts { get; set; }
}