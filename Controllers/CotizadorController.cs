using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Views;
using Cotizador.Models;// REFERENCIAMOS A LA CARPETA MODELS

namespace Cotizador.Controllers
{
    class CotizadorController
    {
               
        // Constructor
        public CotizadorController() 
        {
           

        }
        public decimal obtenerCotizacion(decimal precio, int cantidad,string prenda,string calidad,Boolean mangaCorta, Boolean cuelloMao,Boolean pantalonChuin)
        {
           if(prenda == "CAMISA")
           {
                Camisa cotizarCamisa = new Camisa(precio, cantidad, calidad, mangaCorta, cuelloMao);
                int stock = cotizarCamisa.getStock();
                if (cantidad > stock )
                {
                    return 0;

                }
                if (stock<=0)
                {
                    return 0;
                   
                }
                else
                {
                    return cotizarCamisa.calcularPrecio();
                }
               
               
           }
           else
           {
                Pantalon cotizarPantalon = new Pantalon(precio, cantidad, calidad, pantalonChuin);

                int stock = cotizarPantalon.getStock();
                if (cantidad > stock)
                {
                    return 0;

                }
                if (stock <= 0)
                {
                    return 0;

                }
                else
                {
                    return cotizarPantalon.calcularPrecio();
                }

               
            }
         
        }
        public string[] generarTienda()
        {
            // ESTO DEBE HACERLO EN LA CLASE TIENDA
            Tienda tienda = new Tienda("LOS HIJOS DE PUTA", "DE JOSÉ C. PAZ");
            return tienda.datosTienda();
        }
        public string[] generarVendedor()
        {
            Vendedor vendedor = new Vendedor("334344243", "IGNACIO", "GUTIERREZ");
            return vendedor.datosVendedor();
        }
        
    }
    
}
