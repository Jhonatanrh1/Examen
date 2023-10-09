using examen.Models;
using examen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace examen.Controllers
{
    public class PersonController : ApiController
    {
        // GET api/ Listar todas las personas
        public List<Persona> Get()
        {
            return PersonaData.listar();
        }
        // POST api/ registrar personas 
        public bool Post([FromBody] Persona per)
        {
            return PersonaData.registar(per);
        }

        // PUT api/ editar datos de la personas 
        public bool Put([FromBody] Persona per)
        {
            return PersonaData.editar(per);
        }

        // DELETE api/ eliminar el id de la persona
        public bool Delete(int id)
        {
            return PersonaData.eliminar(id);
        }
    }
}