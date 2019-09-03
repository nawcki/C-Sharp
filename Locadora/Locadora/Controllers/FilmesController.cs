using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Locadora.Models;

namespace Locadora.Controllers
{
    public class FilmesController : Controller
    {

        private static ListaFilmes filmes = new ListaFilmes();

        public ActionResult Index()
        {
            return View(filmes.Lista);   
        }

        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(Filmes filme)
        {
            filmes.CriaUsuario(filme);
            return RedirectToAction("Index");
        }

        public ViewResult Deleta(string id)
        {
            return View(filmes.getFilme(id));
        }

        
        [HttpPost]
        public RedirectToRouteResult Deleta(string id, FormCollection collection)
        {
            
            filmes.Deleta(id);
            return RedirectToAction("Index");
        }

        public ViewResult Atualiza()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Atualiza(Filmes filme)
        {
            var id = filmes.Find(e => e.Name == name);
            //int id = filmes.Lista.IndexOf(filme);
            filmes.Atualiza(id, filme.Name);
            return RedirectToAction("Index");
        }

        public int teste(Filmes filme)
        {
            return 0;
        }
    }

   
}