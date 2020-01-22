using Microsoft.EntityFrameworkCore;
using PrinceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Context
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions Options) : base(Options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Illness> illnesses { get; set; }
    }
}
