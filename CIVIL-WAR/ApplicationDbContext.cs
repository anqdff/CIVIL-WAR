using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIVIL_WAR.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CIVIL_WAR
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<InscriptionModel> InscriptionModels { get; set; }
        public DbSet<Arme> ArmeModel { get; set; }
        public DbSet<Accessoire> AccessoireModel { get; set; }
    }
}
