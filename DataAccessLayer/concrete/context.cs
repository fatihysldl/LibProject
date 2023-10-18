using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrete
{
    public class context :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= Fatih\\SQLEXPRESS; initial catalog=libProjectDb; integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<member> members{ get; set; }
        public DbSet<book> books{ get; set; }
        public DbSet<bookCategory> bookCategories{ get; set; }
        public DbSet<borrowedBook> borrowedBooks{ get; set; }
        public DbSet<admin> admins{ get; set; }
    }
}
