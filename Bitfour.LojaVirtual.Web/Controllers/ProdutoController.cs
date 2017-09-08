using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bitfour.lojaVirtual.Dominio.Repositorio;

namespace Bitfour.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {

        private ProdutoRepositorio _repositorio;

     

        // GET: Produto
        public ActionResult Index()
        {
          _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos;
            return View(produtos);
        }

        public ActionResult Index(string busca = null)
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos;
            return View(produtos);
        }


    }
}