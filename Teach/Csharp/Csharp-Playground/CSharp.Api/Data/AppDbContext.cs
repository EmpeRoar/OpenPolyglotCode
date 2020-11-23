using CSharp.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Api.Data
{
    public static class Constant
    {
        public const string DEFAULT_SCHEMA = "CX";
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<TestItem> TestItems { get; set; }
        public virtual DbSet<ExistResult> ExistResult { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ExistResultConfig());
            modelBuilder.ApplyConfiguration(new TestItemConfig());
        }
    }
}
