using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    internal class Categoria
    {
        private string codigounico;
        private string descripcion;

        public string Codigounico { get { return codigounico; } set { codigounico = value; } }
        public string Descripcion { get {  return descripcion; } set {  descripcion = value; } }
        public override string ToString()
        {
            return Codigounico + " - " + Descripcion;
        }
    }


}
}
