using examen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace examen.Data
{
    public class CasaDatos
    {

        //procedimiento almacenado par Obtener persona id
        public static Casa obtener(int idcasa)
        {
            Casa obtenerCasa = new Casa();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {

                SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idcasa);

                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obtenerCasa = new Casa()
                            {
                                id_casa = Convert.ToInt32(dr["ID_CASA"]),
                                direccion = dr["DIRECCION"].ToString(),
                                numero_habitaciones = Convert.ToInt32(dr["NUMERO_HABITACIONES"]),
                                id_persona = Convert.ToInt32(dr["ID_PERSONA"]),
                                nombre = dr["NOMBRE"].ToString(),
                                apellido_paterno = dr["APELLIDO_PATERNO"].ToString(),
                                apellido_materno = dr["APELLIDO_MATERNO"].ToString(),
                            };
                        }
                    }
                    return obtenerCasa;
                }
                catch (Exception ex)
                {

                    return obtenerCasa;
                }
            }

        }//fin
    }
}