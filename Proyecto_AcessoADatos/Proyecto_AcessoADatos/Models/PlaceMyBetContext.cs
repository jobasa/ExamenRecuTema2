using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class PlaceMyBetContext : DbContext
    {

            public DbSet<Apuestas> Apuestas { get; set; } //Taula
            public DbSet<cuenta> Cuentas { get; set; } //Taula
            public DbSet<Evento> Eventos { get; set; } //Taula
            public DbSet<Mercado> Mercados { get; set; } //Taula
            public DbSet<Usuario> Usuarios { get; set; } //Taula

            public PlaceMyBetContext()
            {
            }

            public PlaceMyBetContext(DbContextOptions options)
            : base(options)
            {
            }

            //Mètode de configuració
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql("Server=127.0.0.1;Port=3306;Database=myDB2;Uid=root;password='';SslMode=none");//màquina retos

                }
            }

            //Inserció inicial de dades
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Evento>().HasData(new Evento(1, "Valencia","Ajax"));
                 modelBuilder.Entity<Grupo>().HasData(new Grupo(2, "Gamma Ray"));
                 modelBuilder.Entity<Grupo>().HasData(new Grupo(3, "Stratovarius"));
                 modelBuilder.Entity<Disco>().HasData(new Disco(1, "The number of the beast", 1982, 1));
                 modelBuilder.Entity<Disco>().HasData(new Disco(2, "Land of the free", 1998, 2));
            }

    }
}