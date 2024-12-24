using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using quanlichannuoi.Model;


namespace quanlichannuoi
{
    public class AppDbcontext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<dsnguoidung> dsnguoidung { get; set; }
        public DbSet<nhom> nhom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-EGUV4U0G\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
           
        }
    }
}
