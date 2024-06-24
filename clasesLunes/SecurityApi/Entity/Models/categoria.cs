using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class categoria
    {

        private int id { get; set; }
        private string code { get; set; }

        private string name { get; set; }

        private bool active { get; set; }

        public List<categoria> categorias { get; set; }




    }
}
