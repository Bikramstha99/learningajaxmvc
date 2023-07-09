using Microsoft.EntityFrameworkCore;

namespace AjaxMvc.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
