using System;

namespace TienditaGrupo52019_1
{
    class Producto
    {
        #region Atributos
        private string nombre;
        private int stock;
        private float precioUnitario;
        private string clave;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get => nombre;
            set
            {
                if (value == "")
                {
                    nombre = "Producto Generico";
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0)
                {
                    stock = 0;
                }
                else
                {
                    stock = value;
                }
            }
        }
        public float PrecioUnitario
        {
            get => precioUnitario;
            set
            {
                if (value < 0)
                {
                    precioUnitario = 1;
                }
                else
                {
                    precioUnitario = value;
                }
            }
        }
        public string Clave
        {
            get => clave;
            set
            {
                if (value == "")
                {
                    clave = "0000";
                }
                else
                {
                    clave = value;
                }
            }
        }
        #endregion

        #region Contructores
        public Producto(string nombre, int stock, float precioUnitario, string clave)
        {
            Nombre = nombre;
            Stock = stock;
            PrecioUnitario = precioUnitario;
            Clave = clave;
        }
        #endregion


    }
}
