using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Models.Dao;// REFERENCIAMOS A LA CARPETA DAO
namespace Cotizador.Models
{
    class Pantalon : Prenda
    {
        private bool pantalonChupin;
        private string codigoPrenda;
        public Pantalon(decimal precio, int cantidad, string calidad, bool pantalonChuin) : base(precio, cantidad, calidad)
        {
            this.pantalonChupin = pantalonChuin;
        }
        public override int getStock()
        {
            ClienteDao db = new ClienteDao();
            int stock = 0;
            // PANTALON CHUPIN
            if (this.pantalonChupin == true  && this.calidad == "STANDARD")
            {
                codigoPrenda = "101";

            }
            if (this.pantalonChupin == true  && this.calidad == "PREMIUM")
            {
                codigoPrenda = "102";

            }
            // PANTALON NORMAL
            if (this.pantalonChupin == false  && this.calidad == "STANDARD")
            {
                codigoPrenda = "103";

            }
            if (this.pantalonChupin == false  && this.calidad == "PREMIUM")
            {
                codigoPrenda = "104";

            }
           
            stock = db.getStock("select STOCK from PANTALON where CODIGO=" + codigoPrenda);
            if (stock >= this.cantidad)
            {
                stock -= this.cantidad;
                db.updateDB("update PANTALON set STOCK='" + stock + "'" + " where codigo=" + codigoPrenda);
            }
            return stock;
        }
        public override decimal calcularPrecio()
        {
            decimal total = 0;
            decimal variacionPrecio ;
            // CHUPIN - REDUCE  12% DEL PRECIO    
            if (this.pantalonChupin == true)
            {
                variacionPrecio = Math.Round(Convert.ToDecimal(this.precio * 0.12M), 2);
                this.precio -= variacionPrecio;
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
                + "'" + idCotizado + "'" + "," + "'" + fecha.ToString() + "'" + "," + "'" + dniVendedor + "'" + "," + "'" + codigoPrenda + "'" + "," + this.cantidad + "," + "'" + total.ToString() + "'" + ")");
            return total;
        }
    }
}
