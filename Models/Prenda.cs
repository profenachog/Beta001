using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Models
{
    abstract class Prenda
    {
        protected decimal precio;
        protected int cantidad;
        protected string calidad;
        private static Random random = new Random();
        protected Prenda(decimal precio, int cantidad, string calidad)
        {
            this.precio = precio;
            this.cantidad = cantidad;
            this.calidad = calidad;
        }
        
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public abstract decimal calcularPrecio();
        public abstract int getStock();
    }
}
