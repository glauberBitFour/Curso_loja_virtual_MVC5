using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitfour.lojaVirtual.Dominio.Entidades;

namespace Bitfour.lojaVirtual.Dominio.Repositorio
{
    public class EfbContext : DbContext
    {


        //mapeando as entidades 
        public DbSet<Produto> Produtos { get; set; }

        //eliminando a pluralização do entity...
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produto");
        }
    }
}
