using APIREST.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APIREST.Conexion
{
    public class Conexion
    {
        static string url = "Data Source = .\\SQLEXPRESS; Initial Catalog = API; Integrated Security = true";

        public static DataTable VerDatos()
        {
            DataSet ds = new DataSet();

            using (SqlDataAdapter da = new SqlDataAdapter("sp_verPersonas",url))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds);
            }

            return ds.Tables[0];
        }

        public static void AgregarPersona(Persona persona)
        {
            DataSet ds = new DataSet();

            using (SqlDataAdapter da = new SqlDataAdapter("sp_InsertarPersonas",url))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@nombre",persona.Nombre);
                da.SelectCommand.Parameters.Add("@apellido", persona.Edad);
                da.SelectCommand.Parameters.Add("@edad", persona.Edad);

                da.Fill(ds);

            }
        } 

        public static void ActualizarPersonas(Persona persona)
        {
            DataSet ds = new DataSet();

            using (SqlDataAdapter da = new SqlDataAdapter("sp_ActualizarPersonas", url))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", persona.Id);
                da.SelectCommand.Parameters.Add("@nombre", persona.Nombre);
                da.SelectCommand.Parameters.Add("@apellido", persona.Edad);
                da.SelectCommand.Parameters.Add("@edad", persona.Edad);

                da.Fill(ds);

            }
        }

        public static void Eliminar(int id)
        {
            DataSet ds = new DataSet();

            using (SqlDataAdapter da = new SqlDataAdapter("sp_EliminarPersonas", url))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", id);
                

                da.Fill(ds);

            }
        }

        public static DataTable VerPersonasPorId(int id)
        {
            DataSet ds = new DataSet();

            using (SqlDataAdapter da = new SqlDataAdapter("sp_VerPersonaPorId", url))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@id", id);


                da.Fill(ds);
            }
            return ds.Tables[0];
        }

    }
}