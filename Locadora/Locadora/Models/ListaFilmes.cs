using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora.Models
{
    public class ListaFilmes
    {
        public List<Filmes> Lista = new List<Filmes>();
        public ListaFilmes()
        {

        }
        public void CriaUsuario(Filmes filmes)
        {
            Lista.Add(filmes);
        }


    }
}