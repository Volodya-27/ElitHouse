using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DataContext( DbContextOptions options) : base(options) { }
        public DbSet<House> Houses { get; set; }

    }
}
