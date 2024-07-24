namespace _2MoneyPOC.Persistance;

public class DbInitializer(MoneyDbContext moneyDbContext)
{
    public void SeedData()
    {
        if (!moneyDbContext.Accounts.Any())
        {
            moneyDbContext.Accounts.AddRange(new List<Account>()
            {
                new Account() {
                    Name = "testAccount1",
                    Ammount = 14738.92M
                },
                new Account() {
                    Name = "testAccount2",
                    Ammount = 994654.21M
                }
            });
            moneyDbContext.SaveChanges();
        }
    }
}
