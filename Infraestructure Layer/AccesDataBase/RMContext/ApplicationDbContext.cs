using Microsoft.EntityFrameworkCore;

namespace AccesDataBase.RMContext;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }
}
