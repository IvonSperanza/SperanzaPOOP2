using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    internal class RepositorioCategoria: Alta
    {

        private List<Categoria> categorias;
        public RepositorioCategorias()
        {
            categorias = new List<Categoria>(); categorias.Add(new Categoria());
        }
        public string Agregar(Categoria item)
        {
            if (item is null);
            var categoriaEncontrada = Buscar(item.Codigo);
            if (categoriaEncontrada == null)
            {
                categorias.Add(item);
                return "Nueva vategoria enocntrada";
            }
            else { return "categoria ya existente"; }
        }
    }
}
