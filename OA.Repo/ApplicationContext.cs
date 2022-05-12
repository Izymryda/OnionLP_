using System;
using Microsoft.EntityFrameworkCore;
using OA.Data;

namespace OA.Repo
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
            new TypeOfRelationMap(modelBuilder.Entity<TypeOfRelation>());
            new UserInRelationMap(modelBuilder.Entity<UserInRelation>());
        }
    }
}
