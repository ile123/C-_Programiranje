using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.DatabaseContext
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Invoice> Invoices { get; set; }
    }

}
