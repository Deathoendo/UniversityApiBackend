using Microsoft.EntityFrameworkCore;
using UniversityDbApi.Models.DataModels;

namespace UniversityDbApi.DataAcess
{
    public class UniversityDBContext : DbContext
    {
       
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) { 

        }
        //TODO: add DbSet (Tables of Data Base)
        public DbSet<User>? Users { get; set; }
    }
}
