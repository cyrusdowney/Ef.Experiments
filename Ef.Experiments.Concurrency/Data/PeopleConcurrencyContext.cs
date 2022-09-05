using Ef.Experiments.Concurrency.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ef.Experiments.Concurrency.Data
{
    public class PeopleConcurrencyContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        public DbSet<PersonConcurency> PeopleConcurency { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=PeopleConcurrency;Trusted_Connection=True;");

            optionsBuilder.LogTo(Console.WriteLine);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().ToList())
            {
                if(entry.State == EntityState.Modified)
                {
                    var baseEntity = entry.Entity as BaseEntity;
                    var updates = entry.OriginalValues;

                    var timeStamp = updates.GetValue<byte[]>("Timestamp");

                    if (baseEntity.Timestamp != timeStamp)
                    {
                        throw new DbUpdateConcurrencyException();
                    }
                }
            }

            var result = base.SaveChanges();

            return result;
        }
    }
}
