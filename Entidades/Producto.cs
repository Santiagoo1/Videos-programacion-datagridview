using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Producto
    {
        #region Atributos
        private int codigo;
        private string descripcion;
        private int stock;
        #endregion
        #region Propiedades
        public int p_Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string p_Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public int p_Stock
        {
            get { return stock; }
        }
        #endregion

        #region Constructores
        public Producto()
        {

        }
        public Producto(int cod, string desc)
        {
            codigo = cod;
            descripcion = desc;
            stock = 0;
        }
        #endregion

        #region Metodos
        public void Ingreso (int cant)
        {
            stock=stock + cant;

        }

        public void salida (int cant)
        {
            stock = stock - cant;

        }
        #endregion
    }
}
