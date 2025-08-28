using Microsoft.EntityFrameworkCore;
using WorkManagementSystem.Models.Entities;

namespace WorkManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 

        public  DbSet<info_user> info_user { get; set; }
        public DbSet<work_booking> work_booking { get; set; }
    }
}
