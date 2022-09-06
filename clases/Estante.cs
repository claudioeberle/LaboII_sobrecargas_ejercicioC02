using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioC02.clases
{
    internal class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante (int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static String MostrarEstante(Estante e)
        {
            string retorno = "";
            string codigo;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Productos: ");
            sb.AppendLine(" ");

            foreach (Producto p in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }
            sb.AppendLine(" ");
            sb.Append("Ubicacion: ");
            sb.Append(e.ubicacionEstante.ToString());

            retorno = sb.ToString();
            return retorno;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool validador = false;
            int length = e.productos.Length;

            for (int i = 0; i < length; i++)
            {
                if (e.productos[i] == (string)p)
                {
                    validador = true;
                    break;
                }
            }
            return validador;
        }

        public static bool operator !=(Estante e, Producto p)
        {     
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool validador = false;
            int length;

            if(!(e==p))
            {
                length = e.productos.Length;

                for (int i = 0; i < length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                    }
                }
                validador = true;
            }
            return validador;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int length = e.productos.Length;

            if (e == p)
            {
                for (int i = 0; i < length; i++)
                {
                    if(e.productos[i] == (string)p)
                    {
                        e.productos[i] = null;
                    }
                }
            }
            return e;
        }
    }
}
