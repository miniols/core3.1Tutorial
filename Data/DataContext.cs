using System.Collections.Generic;
using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) {}
        public DbSet<Character> Character { get; set; }
        public DbSet<User> User { get; set; }
        public List<Character> Characters { get; set; }
    }
}