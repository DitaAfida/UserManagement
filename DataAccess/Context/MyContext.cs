using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base ("MyContext") { }
        public DbSet<Aplication> Aplication { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Regency> Regency { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserApplication> UserApplication { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Village> Village { get; set; }

    }
}
