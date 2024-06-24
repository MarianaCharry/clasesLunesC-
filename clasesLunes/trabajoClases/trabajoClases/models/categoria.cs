using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace trabajoClases.models
{
    internal class categoria
    {
        private string id_categoria { get; set; }
        private string nombre_categoria { get; set; }

        private string descripcion_categoria { get; set; }

        public categoria(string id_categoria, string nombre_categoria, string descripcion_categoria)
        {
            this.id_categoria = id_categoria;
            this.nombre_categoria = nombre_categoria;
            this.descripcion_categoria = descripcion_categoria;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre categoría: {nombre_categoria}, Descripción categoría: {descripcion_categoria}");
        }
    }
}
