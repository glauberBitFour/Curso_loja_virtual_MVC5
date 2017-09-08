using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bitfour.lojaVirtual.Dominio.Entidades;
using Bitfour.lojaVirtual.Dominio.Repositorio;

namespace Bitfour.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutoRepositorio _repositorio;
        public int produtoporpagina = 3;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {

            //chamando os produtos ordenando por nome
            _repositorio = new ProdutoRepositorio();;
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.ProdutoId).Skip((pagina - 1)*produtoporpagina).Take(produtoporpagina);
            
            return View(produtos);
        }

       [HttpGet]
        public ActionResult BuscarPorProdutoPorNome(string nome = null)
       {
            _repositorio = new ProdutoRepositorio();
           if (nome != null)
           {
               //return View(_repositorio.Produtos.Where(p => p.Nome.Contains(nome)).ToList());

              // using (var context = new EfbContext())
              // {
                   //return View(context.Produtos.SqlQuery("Select * from Produto where nome like '%" + nome + "%'").ToList());

                   return View(_repositorio.ProdutoBuscaPorNome(nome));

              // }
           }
           return RedirectToAction("ListaProdutos");


       }
    }
}