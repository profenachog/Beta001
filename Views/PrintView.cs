using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cotizador.Views
{
    public partial class PrintView : Form
    {
        public PrintView()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
          //  printDocument1 = new System.Drawing.Printing.PrintDocument();

           // printDocument1.PrintPage += Imprimir;
          //  printDocument1.Print(txtHistorial.Text);
        }
        private void Imprimir(object sender, EventArgs e)
        {

        }

        private void PrintView_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DEVELOPER3D ; database=cotizador ; integrated security = true");
            conexion.Open();
            string cadena = "select * from COTIZADO";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();
           
            while (registros.Read())
            {
               
                textBox1.AppendText(registros["NUMERO"].ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox2.AppendText(registros["FECHA"].ToString());
                textBox2.AppendText(Environment.NewLine);
                textBox3.AppendText(registros["DNI_VENDEDOR"].ToString());
                textBox3.AppendText(Environment.NewLine);
                textBox4.AppendText(registros["CODIGO_PRENDA"].ToString());
                textBox4.AppendText(Environment.NewLine);
                textBox5.AppendText(registros["CANTIDAD"].ToString());
                textBox5.AppendText(Environment.NewLine);
                textBox6.AppendText(registros["TOTAL"].ToString());
                textBox6.AppendText(Environment.NewLine);
            }
            
            conexion.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
