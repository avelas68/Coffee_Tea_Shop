using System;
using ExampleOne.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleOne.Services

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MyDrinks> Drinkss { get; set; }
    }
}
