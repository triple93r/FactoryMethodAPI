
using FactoryMethodAPI2.Models;
using Microsoft.EntityFrameworkCore;

namespace FactoryMethodAPI2.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public virtual DbSet<Patient> Patients { get; set; }
    }
        
}
