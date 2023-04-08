using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyNewMVC.Models;

namespace MyNewMVC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}