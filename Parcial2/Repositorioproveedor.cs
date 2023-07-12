using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    internal class Repositorioproveedores: Alta
    {
        public class RepositorioProveedores<Proveedor>

        {
            provedor = new List<Provedor>(); 
            provedor.Add(new Provedor());
        }
        public string Agregar(Provedor item)
        {
        
            var provedorEncontrada = Buscar(item.Provedor);
            if (provedorEncontrada == null)
            {
                provedor.Add(item);
                return "Nuevo proveedor agregado";
            }
            else { return "provedor pre cargado"};
        }
        public ReadOnlyCollection<Provedor> Listar()
        {
            return provedor.AsReadOnly();
        }
    }
}
