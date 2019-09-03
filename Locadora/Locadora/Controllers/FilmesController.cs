using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Locadora.Controllers
{
    public class FilmesController : Controller
    {

        private static Models.Filmes filmes = new Models.Filmes();

        public ActionResult Index()
        {
            
            return View(filmes.ListaFilmes);
        }
        public FilmesController()
        {
            
        }
    }
}