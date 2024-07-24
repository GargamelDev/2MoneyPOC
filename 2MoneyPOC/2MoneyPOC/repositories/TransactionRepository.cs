using _2MoneyPOC.Exceptions;
using _2MoneyPOC.Persistance;
using Microsoft.EntityFrameworkCore;

namespace _2MoneyPOC.repositories;

public interface ITransactionRepository
{
    void DeleteTransaction(int id);
    IEnumerable<Transaction> GetTransactionsByAccountId(int accountId);
}

public class TransactionRepository(MoneyDbContext moneyDbContext) : ITransactionRepository
{
    public void DeleteTransaction(int id)
    {
        var transactionToDelete = moneyDbContext.Transactions.Find(id);
        if (transactionToDelete == null)
        {
            throw new BadRequestException("Transaction does not exist!");
        }
        moneyDbContext.Transactions.Remove(transactionToDelete);
        moneyDbContext.SaveChanges();
    }

    public IEnumerable<Transaction> GetTransactionsByAccountId(int accountId)
    {
        return
        moneyDbContext
            .Transactions
            .Include(x => x.Accounts)
            .Where(x =>
                x.Accounts.Select(a => a.Id).Contains(accountId));
    }
}
