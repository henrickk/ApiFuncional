using Microsoft.EntityFrameworkCore;

namespace ApiFuncional.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
    }
}
