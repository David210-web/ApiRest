using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace APIREST.Models
{
    public class RellenarLista
    {


        public static List<Persona> Rellenar()
        {
            List<Persona> personas = new List<Persona>();
            DataTable dt = Conexion.Conexion.VerDatos();

            foreach (DataRow dr in dt.Rows)
            {
                Persona persona = new Persona();
                persona.Id = Int32.Parse(dr["id"].ToString());
                persona.Nombre = dr["nombre"].ToString();
                persona.Apellido = dr["apellido"].ToString();
                persona.Edad = Byte.Parse(dr["edad"].ToString());
                personas.Add(persona);
            }

            return personas;
        }
        public static Persona RellenarPersona(int id)
        {
            DataTable dt = Conexion.Conexion.VerPersonasPorId(id);
            Persona persona = new Persona();

            if(dt.Rows.Count > 0)
            {
               DataRow dr = dt.Rows[0];
               persona.Id = Int32.Parse(dr["id"].ToString());
               persona.Nombre = dr["nombre"].ToString();
               persona.Apellido = dr["apellido"].ToString();
               persona.Edad = Byte.Parse(dr["edad"].ToString());
                
            }

            return persona;
        }

    }
}