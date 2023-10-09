using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen.Models
{
    public class Persona
    {
    public int idPersona { get; set; }
    public string nombre { get; set; }
    public string apellido_paterno { get; set; }
    public string apellido_materno { get; set; }
    public DateTime fecha_nacimiento { get; set; }
    public string direccion { get; set; }

    }
}