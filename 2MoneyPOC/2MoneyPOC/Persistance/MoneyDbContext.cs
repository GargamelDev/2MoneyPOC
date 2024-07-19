using Microsoft.EntityFrameworkCore;

namespace _2MoneyPOC.Persistance;

public class MoneyDbContext : DbContext
{
    public MoneyDbContext(DbContextOptions<MoneyDbContext> options) : base(options)
    {

    }
    public DbSet<Account> Accounts { get; set; }
}
