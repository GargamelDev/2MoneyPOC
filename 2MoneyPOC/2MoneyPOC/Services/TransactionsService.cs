using _2MoneyPOC.Dtos;
using _2MoneyPOC.repositories;

namespace _2MoneyPOC.Services;

public interface ITransactionsService
{
    void DeleteTransaction(int id);
    IEnumerable<GetTransactionDTO> GetTransactionsByAccountId(int accountId);
}

public class TransactionsService(ITransactionRepository transactionRepository) : ITransactionsService
{
    public void DeleteTransaction(int id)
    {
        transactionRepository.DeleteTransaction(id);
    }

    public IEnumerable<GetTransactionDTO> GetTransactionsByAccountId(int accountId)
    {
        throw new NotImplementedException();
    }
}
