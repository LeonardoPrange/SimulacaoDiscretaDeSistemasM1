using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiNetFramework.Models;

namespace WebApiNetFramework.Context
{
    public class WebApiNetFrameworkContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Imagem> Imagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}