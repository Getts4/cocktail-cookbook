using Microsoft.EntityFrameworkCore;
using CocktailCookbook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CocktailCookbook.Api.Data
{
    public class DrinksContext : DbContext
    {
        public DrinksContext(DbContextOptions<DrinksContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder) =>
    base.OnModelCreating(builder);

        public DbSet<Drinks> Drinks {get;set;}
        
    }
}