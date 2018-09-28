using System;
using System.Collections;
using System.Drawing;
using ManejaProducto;
using InterfazPago;
using System.Windows.Forms;

namespace TienditaGrupo52019_1
{
    public partial class Form1 : Form,IMPago
    {

        #region Atributos
        Producto miproducto;
        ArrayList productos;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            productos = new ArrayList();
            productos.Add(new Producto("Refresco",20,12,"12542155"));
            productos.Add(new Producto("Papitas",300,10.5f,"2223414"));
            productos.Add(new Producto("Cerveza", 1000, 15.80f, "232234235"));
            foreach(Producto producto in productos)
            {
                cmbProducto.Items.Add(producto.Nombre);
            }
        }
        #endregion
        
        #region Eventos 
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            miproducto = (Producto)productos[cmbProducto.SelectedIndex];
            txtbClavedelproducto.Text = miproducto.Clave;
            txtbPreciounidad.Text = Convert.ToString(miproducto.PrecioUnitario);
            txtbAlmacen.Text = Convert.ToString(miproducto.Stock);            
        }

        private void cmbProducto_Efectivo(object sender, EventArgs e)
        {
            rdbEfectivo.Checked = true;
        }
        private void rdbTarjetacredito_CheckedChanged(object sender, EventArgs e)
        {
            txtbEfectivo.Visible = false;
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txtbEfectivo.Visible = true;
            if (rdbEfectivo.Checked)
            {
                lbResultadoPago.Text = "Efectivo";
            }
            else
            {
                lbResultadoPago.Text = "Tarjeta";
            }

        }

        private void txtbCantidadCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(  e.KeyChar == (char)Keys.Enter   )
            {
                float tot = float.Parse(txtbCantidadCliente.Text) * float.Parse(txtbPreciounidad.Text);
                lbResultadoTotal.Text = tot.ToString();
                lbResultadoProducto.Text = miproducto.Nombre;
                lbResultadoUnidades.Text = txtbCantidadCliente.Text;
                

            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(rdbEfectivo.Checked)
            {
                float cambio= Efectivo(float.Parse(lbResultadoTotal.Text), float.Parse(txtbEfectivo.Text));
                MessageBox.Show("$"+cambio.ToString()," CAMBIO ");
            }
            if(rdbTarjetacredito.Checked)
            {
                FormTarjeta formTarjeta = new FormTarjeta();
                formTarjeta.Show();
            }
        }

        #endregion 

        #region Implentacion Interfaz
        public float Efectivo(float total, float efectivo)
        {

            try
            {
                if (int.Parse(txtbCantidadCliente.Text) > int.Parse(txtbAlmacen.Text))
                {
                    throw new ApplicationException("No existen suficientes productos");
                }
                float tot;
                tot = float.Parse(txtbCantidadCliente.Text) * float.Parse(txtbPreciounidad.Text);
                return efectivo - tot;
            }
            catch (ApplicationException error)
            {
                errorProv.SetError(txtbCantidadCliente, error.Message);
                return -1;
            }
            catch (FormatException)
            {
                errorProv.SetError(txtbCantidadCliente, "Cantidad no valida");
                return -1;
            }

        }

        public bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string Cvv)
        {
            throw new NotImplementedException();
        }

        #endregion

        private void txtbCantidadCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
 