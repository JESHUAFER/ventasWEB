using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ventasWEB.Models;

namespace ventasWEB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //generar una instancia al modelo appUsuarios
        public DbSet<AppUsuarios> AppUsuarios { get; set; }

    }
}
