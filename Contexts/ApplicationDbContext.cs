using Microsoft.EntityFrameworkCore;
using WebAPi_Kairos.Entities;

namespace WebAPi_Kairos.Contexts {
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
