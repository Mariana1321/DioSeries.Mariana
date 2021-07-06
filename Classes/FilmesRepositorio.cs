using System;
using System.Collections.Generic;
using Filmes.Mariana.Intefaces;


namespace Filmes.Mariana
{
    public class FilmesRepositorio : IRepositorioFilmes<Filmes>
    {
         private List<Filmes> listaFilmes = new List<Filmes>();
		public void Atualiza(int id, Filmes objeto)
		{
			listaFilmes[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaFilmes[id].Excluir();
		}

		public void Insere(Filmes objeto)
		{
			listaFilmes.Add(objeto);
		}

		public List<Filmes> Lista()
		{
			return listaFilmes;
		}

		public int ProximoId()
		{
			return listaFilmes.Count;
		}

		public Filmes RetornaPorId(int id)
		{
			return listaFilmes[id];
		}
    }

   
}