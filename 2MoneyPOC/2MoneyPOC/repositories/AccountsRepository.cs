using _2MoneyPOC.Persistance;

namespace _2MoneyPOC.repositories
{
    public interface IAccountsRepository
    {
        IEnumerable<Account> GetAccounts();
    }

    public class AccountsRepository(MoneyDbContext _moneyDbContext) : IAccountsRepository
    {
        public IEnumerable<Account> GetAccounts()
        {
            return _moneyDbContext.Accounts.ToList();
        }
    }
}
