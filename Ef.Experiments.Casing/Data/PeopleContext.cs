using Ef.Experiments.Casing.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef.Experiments.Casing.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=People;Trusted_Connection=True;");

            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
