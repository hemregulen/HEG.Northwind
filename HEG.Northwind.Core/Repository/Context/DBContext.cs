using HEG.Northwind.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.Northwind.Core.Repository.Context
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True;");
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
    }
}
