using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Models.Dao;// REFERENCIAMOS A LA CARPETA MODELS
namespace Cotizador.Models
{
    class Tienda
    {
        private String nombre;
        private String direccion;
        public Tienda( String value1, String value2)
        {
            this.nombre = value1;
            this.direccion = value2;
           
        }
        public string[] datosTienda()
        {
            
            string[] datosTienda = { this.nombre, this.direccion };
            return datosTienda;
        }
       
    }
}
