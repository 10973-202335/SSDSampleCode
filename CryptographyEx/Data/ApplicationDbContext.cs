using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CryptographyEx.Models;

namespace CryptographyEx.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CryptographyEx.Models.Password>? Password { get; set; }
        public DbSet<CryptographyEx.Models.BankAccount>? BankAccount { get; set; }
        public DbSet<CryptographyEx.Models.BankAccountData>? BankAccountData { get; set; }
    }
}