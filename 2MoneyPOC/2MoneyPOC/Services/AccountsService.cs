using _2MoneyPOC.Dtos;
using _2MoneyPOC.repositories;
using AutoMapper;

namespace _2MoneyPOC.Services;

public interface IAccountsService
{
    IEnumerable<GetAccountDTO> GetAccounts();
}

public class AccountsService(IAccountsRepository _accountsRepository, IMapper _mapper) : IAccountsService
{
    public IEnumerable<GetAccountDTO> GetAccounts()
    {
        var accounts = _accountsRepository.GetAccounts();

        var getAccountDTOs = _mapper.Map<IEnumerable<GetAccountDTO>>(accounts);

        return getAccountDTOs;
    }
}
