using Microsoft.EntityFrameworkCore;
using PegawaiMVC.Models;

namespace PegawaiMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Pegawai> Pegawais{get; set;}
    }
}