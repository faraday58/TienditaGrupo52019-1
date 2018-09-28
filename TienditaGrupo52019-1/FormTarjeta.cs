using System;
using System.Drawing;
using System.Windows.Forms;

namespace TienditaGrupo52019_1
{
    public partial class FormTarjeta : Form
    {
        private string numerotarjeta;
        private string cvv;
        private string fecha;
        private float totalPagar;
        private float saldo;


        public string Numerotarjeta { get => numerotarjeta; set => numerotarjeta = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }
        public float Saldo { get => saldo; set => saldo = value; }

        public FormTarjeta(float TotalPagar)
        {
            InitializeComponent();
            this.TotalPagar = TotalPagar;
            lblTotalPagar.Text =this.TotalPagar.ToString();


        }
        
        private void btnPago_Click(object sender, EventArgs e)
        {
            Random saldoVariable = new Random();
            Numerotarjeta = mtbNumeroTarjeta.Text;
            Cvv = mtbCvv.Text;
            Fecha = mtbVencimiento.Text;
            Saldo = (float)saldoVariable.NextDouble()*1000;
            lbprueba.Text = Fecha;
        }

       }
 }

