
using System.Data.SqlClient;


namespace Cotizador.Models.Dao
{
    public class DbContex
    {
       protected SqlConnection conexion = new SqlConnection("server=DEVELOPER3D ; database=cotizador ; integrated security = true");
       
    }
}
