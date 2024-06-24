using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class producto
    {
        private string id { get; set; }

        private string name { get; set; }

        private decimal price { get; set; }

        private decimal description { get; set; }

        private decimal brand { get; set; }

        private decimal code { get; set; }

        private bool active { get; set; }

        public categoria categoria { get; set; }
    }
}
