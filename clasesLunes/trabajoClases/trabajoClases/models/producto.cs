using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoClases.models
{
    internal class producto
    {

        private string id_producto {get;set;}

        private string nombre_producto {get;set;}

        private double precio_producto {get;set;}

        public categoria categoria {get;set;}

        public producto(string id_producto, string nombre_producto, double precio_producto, categoria categoria)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.precio_producto = precio_producto;
            this.categoria = categoria;
        }

    }
}
