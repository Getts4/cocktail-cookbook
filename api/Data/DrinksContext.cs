using Microsoft.EntityFrameworkCore;
using CocktailCookbook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CocktailCookbook.Api.Data
{
    public class DrinksContext : IdentityDbContext<ApplicationUser>
    {
        public DrinksContext(DbContextOptions<DrinksContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder) =>
    base.OnModelCreating(builder);

        public DbSet<Drinks> Drinks {get;set;}
        
    }
}