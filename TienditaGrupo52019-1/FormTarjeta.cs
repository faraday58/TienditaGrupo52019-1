using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienditaGrupo52019_1
{
    public partial class FormTarjeta : Form
    {
        private string numerotarjeta;
        private string cvv;
        private string fecha;

        public string Numerotarjeta { get => numerotarjeta; set => numerotarjeta = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string Fecha { get => fecha; set => fecha = value; }

        public FormTarjeta()
        {
            InitializeComponent();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Numerotarjeta = mtbNumeroTarjeta.Text;

        }
    }
}
