using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torres_Anibal_Parcial
{
    public partial class FAlquiler : Form
    {
        ConexionDB objConexion = new ConexionDB ();
        string accion = "nuevo";
        public FAlquiler()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Fmenu cambio = new Fmenu();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            FBusquedaregistroalquiler cambio = new FBusquedaregistroalquiler();
            this.Hide();
            cambio.ShowDialog();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (btnmodificar.Text == "Modificar")
            {
                btnagregar.Text = "guardar";
                btnmodificar.Text = "cancelar";
                accion = "nuevo";

                //controles(false);

                btnagregar.Text = "guardar";
                btnmodificar.Text = "cancelar";
            }
            else
            {
               //Controles(true);
                //MostrarDatos(); 

                btnagregar.Text = "nuevo";
                btnmodificar.Text = "modificar";
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("esta seguro de eliminar a " + cbclientes.Text, "registro", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) ;
            {
                String[] valores = { lblidalquiler.Text };
                //objConexion.mantenimiento_ventas(valores, "Eliminar");
                //ActualizarDs();
                //posicion = posicion > 0 ? posicion - 1 : 0;
                //MostrarDatos();
            }
        }



        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (btnagregar.Text == "nuevo")
            {
                btnagregar.Text = "guardar";
                btnmodificar.Text = "cancela";
                accion = "nuevo";

                //limpiar_cajas();
                //controles(false);
            }
            else
            {
                String[] valores = {
                    lblidalquiler.Text,
                    cbclientes.Text,
                    cbpeliculas.Text,
                    txtfprestamo.Text, 
                    txtfdevolucion.Text, 
                    txtduracion.Text, 
                    txtvalor.Text, 
                };
                objConexion.movimiento_clientes(valores, accion);
                // ActualizarDs;
                // posicion = tbl.Rows.Count - 1;
                // MostrarDatos();

                //Controles(true);
                btnagregar.Text = "nuevo";
                btnmodificar.Text = "modificar";
            }
        }

        private void cbclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
