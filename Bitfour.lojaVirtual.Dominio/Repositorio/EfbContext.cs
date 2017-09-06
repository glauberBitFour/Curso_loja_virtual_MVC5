using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitfour.lojaVirtual.Dominio.Entidades;

namespace Bitfour.lojaVirtual.Dominio.Repositorio
{
    public class EfbContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }
    }
}
