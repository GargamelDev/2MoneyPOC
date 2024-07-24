using _2MoneyPOC.Dtos;
using _2MoneyPOC.Persistance;
using AutoMapper;

namespace _2MoneyPOC;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<Account, GetAccountDTO>();
    }
}
