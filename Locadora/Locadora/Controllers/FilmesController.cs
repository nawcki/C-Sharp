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
    }
}