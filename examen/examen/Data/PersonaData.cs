using examen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace examen.Data
{
    public class PersonaData
    {

        //procedimiento almacenado par registrar
        public static bool registar(Persona per)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn)) {

                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", per.nombre);
                cmd.Parameters.AddWithValue("@apellido_paterno", per.apellido_paterno);
                cmd.Parameters.AddWithValue("@apellido_materno", per.apellido_materno);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", per.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@direccion", per.direccion);


                try
                {

                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                {

                    return false;
                }
            }

        }//fin

        //procedimiento almacenado par Editar
        public static bool editar(Persona per)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {

                SqlCommand cmd = new SqlCommand("usp_editar", oConexion);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", per.idPersona);
                cmd.Parameters.AddWithValue("@nombre", per.nombre);
                cmd.Parameters.AddWithValue("@apellido_paterno", per.apellido_paterno);
                cmd.Parameters.AddWithValue("@apellido_materno", per.apellido_materno);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", per.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@direccion", per.direccion);


                try
                {

                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                {

                    return false;
                }
            }

        }//fin

        //procedimiento almacenado par listar
        public static List<Persona> listar()
        {
            List<Persona> listaPerso = new List<Persona>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {

                SqlCommand cmd = new SqlCommand("usp_listar", oConexion);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
               
                try
                {

                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) {
                            listaPerso.Add(new Persona()
                            {
                                idPersona = Convert.ToInt32(dr["ID_PERSONA"]),
                                nombre = dr["NOMBRE"].ToString(),
                                apellido_paterno = dr["APELLIDO_PATERNO"].ToString(),
                                apellido_materno = dr["APELLIDO_MATERNO"].ToString(),
                                fecha_nacimiento = Convert.ToDateTime(dr["FECHA_NACIMIENTO"].ToString()),
                                direccion = dr["DIRECCION"].ToString()

                            });
                        }
                    }
                    return listaPerso;
                }
                catch (Exception ex)
                {

                    return listaPerso;
                }
            }

        }//fin

        //procedimiento almacenado par eliminar persona id
        public static bool eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {

                SqlCommand cmd = new SqlCommand("usp_eliminar", oConexion);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpersona", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {

                    return false;
                }
            }

        }//fin
    }
}