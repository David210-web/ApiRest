using APIREST.Conexion;
using APIREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIREST.Controllers
{
    public class PersonaController : ApiController
    {
        // GET: api/Persona
        public IEnumerable<Persona> Get()
        {
            return RellenarLista.Rellenar();
        }

        // GET: api/Persona/5
        public Persona Get(int id)
        {
            return RellenarLista.RellenarPersona(id);
        }

        // POST: api/Persona
        public string Post([FromBody]Persona value)
        {
            Conexion.Conexion.AgregarPersona(value);
            return "Dato Insertado con exito";
        }

        // PUT: api/Persona/5
        public string Put(int id, [FromBody]Persona value)
        {
            Conexion.Conexion.ActualizarPersonas(value);
            return "Dato Actualizado con exito";
        }

        // DELETE: api/Persona/5
        public string Delete(int id)
        {
            Conexion.Conexion.Eliminar(id);
            return "Dato eliminado con exito";
        }
    }
}
