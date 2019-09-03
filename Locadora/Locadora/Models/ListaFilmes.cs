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


        public Filmes getFilme(string name)
        {
            Filmes novofilme = null;
            foreach (Filmes filme in Lista)
            {
                if (filme.Name == name)
                {
                    novofilme = filme;
                    return novofilme;
                }
            }
            return null;
        }

        public void Deleta(string name)
        {
            foreach(Filmes filmes in Lista)
            {
                if (filmes.Name == name)
                {
                    Lista.Remove(filmes);
                    break;
                }
            }
        }

        public void Atualiza(Filmes filmes)
        {
            foreach(Filmes procura in Lista)
            {
                if (procura.Name == filmes.Name)
                {
                    Lista.Remove(filmes);
                    Lista.Add(filmes);
                    break;
                }
            }
        }

    }
}