using examen.Data;
using examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace examen.Controllers
{
    public class HouseController : ApiController
    {
        // GET api/Listar todas las casa por ID
        public Casa Get(int id)
        {
        return CasaDatos.obtener(id);
        }
    }
}