using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cotizador.Models.Dao
{
    class ClienteDao : DbContex
    {
        public int getStock(string cadena)
        {
            string dataStock="0";
            this.conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, this.conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                dataStock = registro["STOCK"].ToString();
            }
            this.conexion.Close();
            int stock = int.Parse(dataStock);
            return stock;

        }
        public void updateDB(string cadena)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        
        }
       
        
    }
}
