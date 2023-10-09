using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen.Models
{
    public class Casa
    {
        public int id_casa { get; set; }
        public string direccion { get; set; }
        public int numero_habitaciones { get; set; }
        public int id_persona { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }


    }
}