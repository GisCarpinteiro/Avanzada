using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_cine3
{
    class Cliente
    {
        public string nombre { get; set; }
        public string id { get; set; }
        public int nasientos { get; set; }
        public double total { get; set; }



        public Cliente(string nombre, string id, int nasientos)
        {
            this.nombre = nombre;
            this.id = id;
            this.nasientos = nasientos;
        }
    }
}
