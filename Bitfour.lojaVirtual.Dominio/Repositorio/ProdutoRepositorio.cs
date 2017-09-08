using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitfour.lojaVirtual.Dominio.Entidades;

namespace Bitfour.lojaVirtual.Dominio.Repositorio
{
    public class ProdutoRepositorio : IDisposable
    {
        private readonly EfbContext _context = new EfbContext();

        public IEnumerable<Produto> Produtos
        {
            get
            {
                return _context.Produtos;
            }
        }

        //busca produtos por Nome
        public List<Produto> ProdutoBuscaPorNome(string nome = null)
        {
            return _context.Produtos.SqlQuery("Select * from Produto where nome like '%" + nome + "%'").ToList();
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}

