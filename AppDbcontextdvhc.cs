using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using quanlichannuoi.Model;



namespace quanlichannuoi
{
    public class AppDbcontextdvhc : DbContext
    {
        public DbSet<Huyen> Huyens { get; set; }
        public DbSet<Xa> Xas { get; set; }
        public DbSet<Cososanxuat> Cososanxuats { get; set; }
        public DbSet<cosokhaonghiem> cosokhaonghiem { get; set; }
        public DbSet<cosochannuoi> cosochannuoi { get; set; }
        public DbSet<dieukienchannuoi> dieukienchannuoi { get; set; }
        public DbSet<giaychungnhancoso> giaychungnhancoso { get; set; }
        public DbSet<tochuccapphep> tochuccapphep { get; set; }
        public DbSet<cosochebien> cosochebien {  get; set; } 
        public DbSet<vitri> vitri { get; set; }
        public DbSet<chicucthuy> chicucthuy { get; set; }
        public DbSet<dailybanthuoc> dailybanthuoc { get; set; }
        public DbSet<khutamgiu> khutamgiu { get; set; }
        public DbSet<cosogietmo> cosogietmo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-EGUV4U0G\\SQLEXPRESS;Initial Catalog=donvihanhchinh;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
