using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using LawyerSuits.Domain;

namespace LawyerSuits.DAL
{
    public partial class LawyerSuitsDbContext : DbContext
    {
        private static bool _created = false;
        public LawyerSuitsDbContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source= LawyerSuits.db");
        }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public LawyerSuitsDbContext(DbContextOptions<LawyerSuitsDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<SuitItem> Lawsuits { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
    }
}
