using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    internal class Repositorioproducto: Alta
    {
        public class RepositorioProducto<Producto>

        {
            producto = new List<Producto>(); 
            producto.Add(new Producto());


        }

        public void AgregarProducto(Producto producto, int codigo)
        {
            if (producto.Stock >= codigo)
            {
                Detalles.Add(producto, codigo);
                producto.Stock _ = codigo;
            }
        }
        public ReadOnlyCollection<Producto> Listar()
        {
            return producto.AsReadOnly();
        }
    }
