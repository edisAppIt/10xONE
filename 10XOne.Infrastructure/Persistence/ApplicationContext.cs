using System;
using _10XOne.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace _10XOne.Infrastructure.Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
        }

        public DbSet<Partner> Partners { get; set; }

        public DbSet<FinancialItem> FinancialItems { get; set; }
        
    }
}
