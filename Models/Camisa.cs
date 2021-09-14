using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Models.Dao;// REFERENCIAMOS A LA CARPETA DAO
namespace Cotizador.Models
{
    class Camisa: Prenda
    {
        private bool mangaCorta;
        private bool cuelloMao;
        private string codigoPrenda;
        public Camisa(decimal precio, int cantidad, string calidad, bool mangaCorta, bool cuelloMao) :base( precio,  cantidad,  calidad)
        {
            this.mangaCorta = mangaCorta;
            this.cuelloMao = cuelloMao;
        }
        public override int getStock()
        {
            ClienteDao db = new ClienteDao();
            int stock=0;
            // CAMISA CORTA
            if (this.mangaCorta == true && this.cuelloMao == false && this.calidad == "STANDARD")
            {
                codigoPrenda = "001";
                
            }
            if (this.mangaCorta == true && this.cuelloMao == false && this.calidad == "PREMIUM")
            {
                codigoPrenda = "002";
              
            }
            if (this.mangaCorta == true && this.cuelloMao == true && this.calidad == "STANDARD")
            {
                codigoPrenda = "003";
             
            }
            if (this.mangaCorta == true && this.cuelloMao == true && this.calidad == "PREMIUM")
            {
                codigoPrenda = "004";
             
            }
            // CAMISA LARGA
            if (this.mangaCorta == false && this.cuelloMao == true && this.calidad == "STANDARD")
            {
                codigoPrenda = "005";
               
            }
            if (this.mangaCorta == false && this.cuelloMao == true && this.calidad == "PREMIUM")
            {
                codigoPrenda = "006";
              
            }
            if (this.mangaCorta == false && this.cuelloMao == false && this.calidad == "STANDARD")
            {
                codigoPrenda = "007";
              
            }
            if (this.mangaCorta == false && this.cuelloMao == false && this.calidad == "PREMIUM")
            {
                codigoPrenda = "008";
              
            }
            stock = db.getStock("select STOCK from CAMISA where CODIGO=" + codigoPrenda);
            if (stock >= cantidad)
            {
                stock -= cantidad;
                db.updateDB("update CAMISA set STOCK='" + stock + "'" + " where codigo=" + codigoPrenda);
            }
            return stock;
        }
        public  override decimal calcularPrecio()
        {

            decimal total = 0;
            decimal variacionPrecio;
            // MANGA CORTA - REDUCE 10% DEL PRECIO
            if (this.mangaCorta == true)
            {
                variacionPrecio = Math.Round(Convert.ToDecimal(this.precio * 0.10M), 2);
                this.precio -= variacionPrecio; 
            }
            // CUELLO MAO - AUMENTA  3% DEL PRECIO
            if (this.cuelloMao == true)
            {
                variacionPrecio = Math.Round(Convert.ToDecimal(this.precio * 0.03M), 2);
                this.precio += variacionPrecio;
            }
            // PREMIUM - AUMENTA  30% DEL PRECIO
            if (this.calidad == "PREMIUM")
            {
                variacionPrecio = Math.Round(Convert.ToDecimal(this.precio * 0.30M), 2);
                this.precio += variacionPrecio;
            }
            
            total = total + (this.precio * this.cantidad);
            ClienteDao db = new ClienteDao();
            DateTime fecha = DateTime.Now;
            string dniVendedor = "334344243";
            string idCotizado = this.RandomString(8);
            // INSERTO LOS VALORES A LA TABLA COTIZADO
            db.updateDB("insert into COTIZADO(NUMERO, FECHA, DNI_VENDEDOR, CODIGO_PRENDA, CANTIDAD, TOTAL) values("
                + "'"+ idCotizado + "'" + "," + "'" + fecha.ToString() + "'" + "," + "'" +dniVendedor + "'"+"," + "'"+ codigoPrenda +"'" + "," + this.cantidad + "," + "'" + total.ToString() + "'" + ")");

          
            return total;
        }
       
    }
}
