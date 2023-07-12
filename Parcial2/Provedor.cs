using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    internal class Provedor
    {
        private int codigoproveddor;
        private int cuit;
        private string nombre;
        
        private string direccion;
        public situacionfiscal;


        public int Codigoproveedor { get {  return codigoproveddor; } set {  codigoproveddor = value;} }
        public int Cuit { get {  return cuit; } set {  cuit = value; } }
        public string Nombre { get {  return nombre; } set {  nombre = value; } }

        public string Direccion { get {  return direccion; } set {  direccion = value; } }

    
    }
}
