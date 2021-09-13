using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.Data.Models;

namespace WebApplication17.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(
                @"
                    Server = (localdb)\MSSQLLocalDB;
                    DataBase = LocalDB2;
                    Trusted_Connection= True;
                ");
        }
    }
}
