using Microsoft.EntityFrameworkCore;
using System;

namespace Applications.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add some seed data
            modelBuilder.Entity<Application>().HasData(new[]
            {
                new Application
                {
                    ApplicationId=Guid.NewGuid(),
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Form = "{\"Name\": \"John Doe\"}"
                },
                new Application
                {
                    ApplicationId=Guid.NewGuid(),
                    Created = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    Form = "{\"Name\": \"Sue Hunter\"}"
                }
            });
        }
        public DbSet<Application> Applications { get; set; }
    }
}