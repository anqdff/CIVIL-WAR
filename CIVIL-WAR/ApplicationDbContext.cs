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
        public DbSet<Panier> PaniersModel { get; set; }

        //commande pour ajouter une migration 
        //add-migration Initial-commit-Application -Context ApplicationDbContext -o Migrations/Application
        //commande pour mettre à jour la base avec la migration récente
        //update-database -Context ApplicationDbContext 
    }
}
