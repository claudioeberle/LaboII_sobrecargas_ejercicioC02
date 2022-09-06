using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioC02.clases
{
    internal class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public string GetPrecio()
        {
            return (this.precio).ToString();
        }

        public static string MostrarProducto(Producto p)
        {
            string producto = "";

            if (p is not null)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("Marca: ");
                sb.Append(p.marca);
                sb.Append(",");
                sb.Append("Precio: ");
                sb.Append(p.precio.ToString());
                sb.Append("Código de Barras: ");
                sb.AppendLine(p.codigoDeBarra);

                producto = sb.ToString();
            }
            return producto;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool validador = false;

            if((p1.marca == p2.marca) && ((string)p1 == (string)p2))
            {
                validador = true;
            }

            return validador;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, String marca)
        {
            bool validador = false;

            if (p is not null && p.marca == marca)
            {
                validador = true;
            }
            return validador;
        }

        public static bool operator !=(Producto p, String marca)
        {
            return !(p == marca);
        }




    }
}
