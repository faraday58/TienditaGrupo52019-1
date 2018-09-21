using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienditaGrupo52019_1
{
    public partial class Form1 : Form,IMPago
    {
        Producto miproducto;
        ArrayList productos;

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
       
        public float Efectivo(float total, float efectivo)
        {
            
            try
            {
            if (int.Parse(txtbCantidadCliente.Text) > int.Parse(txtbAlmacen.Text)  )
                {
                    throw new ApplicationException("No existen suficientes productos");
                }
                    float tot;
                tot = float.Parse(txtbCantidadCliente.Text) * int.Parse(txtbPreciounidad.Text);
                return efectivo - tot;
            }
            catch (ApplicationException error)
            {
                errorProv.SetError(txtbCantidadCliente, error.Message);
            }
              catch (FormatException )
            {
                errorProv.SetError(txtbCantidadCliente, "Cantidad no valida");

            }
            return -1;
        }

        public bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string Cvv)
        {
            throw new NotImplementedException();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            miproducto = (Producto)productos[cmbProducto.SelectedIndex];
            txtbClavedelproducto.Text = miproducto.Clave;
            txtbPreciounidad.Text = Convert.ToString(miproducto.PrecioUnitario);
            txtbAlmacen.Text = Convert.ToString(miproducto.Stock);

            
        }


        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txtbEfectivo.Visible = true;  
        }
    }
}
