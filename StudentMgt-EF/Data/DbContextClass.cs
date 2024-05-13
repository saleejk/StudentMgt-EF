using Microsoft.EntityFrameworkCore;
using StudentMgt_EF.ModelEntity;
using System.Data.Common;

namespace StudentMgt_EF.Data
{
    public class DbContextClass : DbContext
    {
        private readonly IConfiguration _configuration;
        public string connectionString {  get; set; }
        public DbContextClass(IConfiguration config)
        {
            _configuration = config;
            connectionString = _configuration["ConnectionStrings:DefaultConnection"];

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Student> newStudents { get; set; }
    }
}
