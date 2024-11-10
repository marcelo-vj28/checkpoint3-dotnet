using CP3.MVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CP3.MVC.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<BarcoEntity> Barco { get; set; }
    }
}
