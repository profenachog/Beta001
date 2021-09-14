using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Models
{
    class Vendedor
    {
        private String nombre ;
        private String apellido;
        private String DNI;
        public Vendedor(String id,String nombre, String apellido )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = id;

        }

        public string[] datosVendedor()
        {

            string[] datosTienda = { this.DNI, this.nombre, this.apellido };
            return datosTienda;
        }
    }
}
