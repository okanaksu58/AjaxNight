using Microsoft.EntityFrameworkCore;

namespace AjaxNight.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9B3JVRI;initial Catalog=AjaxNight;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
