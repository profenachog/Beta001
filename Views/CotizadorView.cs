using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cotizador.Controllers; // REFERENCIAMOS A LA CARPETA CONTROLLES

namespace Cotizador.Views
{
    public partial class CotizadorView : Form
    {
        CotizadorController ctrl;
        private decimal precio;
        private int cantidad;
        public CotizadorView()
        {
            InitializeComponent();
            ctrl = new CotizadorController(); // INSTANCIAMOS y ENVIAMOS EL FORMULARIO CON THIS
            
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
           
            string prenda;
            string calidad;
            
            if (rdoCamisa.Checked == true)
            {
                prenda = "CAMISA";
               
            }
            else
            {
                prenda = "PANTALON";
            }
            if (rdoPremium.Checked == true)
            {
                calidad = "PREMIUM";

            }
            else
            {
                calidad = "STANDARD";
            }

            // VALIDAR ENTRADA DE DATOS 
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("ERROR", "ESTE CAMPO NO PUEDE QUEDAR VACIO");
                txtPrecio.Focus();
            }
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("ERROR", "ESTE CAMPO NO PUEDE QUEDAR VACIO");
                txtCantidad.Focus();
               
            }


            if (txtPrecio.Text != "" && txtCantidad.Text != "")
            {
                try
                {
                    precio = decimal.Parse(txtPrecio.Text);
                    cantidad = int.Parse(txtCantidad.Text);
                    decimal total = ctrl.obtenerCotizacion(precio, cantidad, prenda, calidad, chkMangaCorta.Checked, chkMao.Checked, chkChupin.Checked);
                    if (total > 0)
                    {
                        lblTotal.Text = total.ToString();
                        // COTIZACION FINALIZADA
                        MessageBox.Show("GRACIAS POR USAR COTIZADOR EXPRESS 001 BETA", "*************COTIZACIÓN FINALIZADA************");
                    }
                    else
                    {
                        MessageBox.Show("COMUNICATE CON EL DUEÑO DE LA TIENDA INMEDIATEMENTE", "************SIN STOCK***************");
                        lblTotal.Text = "*** SIN STOCK ***";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("NO ES UN NUMERO VALIDO", "ERROR");
                }
            }

               

          
            

        }
        // INICIA LA VISTA
        private void CotizadorView_Load(object sender, EventArgs e)
        {
            // CREAMOS LA TIENDA
            string[] tienda = ctrl.generarTienda();
            lblTienda.Text = tienda[0];
            lblDireccion.Text = tienda[1];
          
            // CREAMOS EL VENDEDOR
            string[] vendedor = ctrl.generarVendedor();
            lblId.Text = vendedor[0];
            lblVendedor.Text = vendedor[1] + " " + vendedor[2];

        }
        // MUESTRA EL HISTORIAL DE COTIZACIONES
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            PrintView frm = new PrintView();
            frm.Show();

        }
     

    }
}
