using InvoiceProcessorDesktopLegacy.Entities;
using System.Data.Entity;

namespace InvoiceProcessorDesktopLegacy.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=NotaFiscalConnection")
        {
        }

        public DbSet<NotaFiscal> NotasFiscais { get; set; }
    }
}
