using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Empleado
    {
        public List<CE_Huella_Empleado> ListarEmpleados()
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            List<CE_Huella_Empleado> lstEmpleados = new List<CE_Huella_Empleado>();

            using (cn = conexion.ConexionSql())
            {
                cn.Open();

                using (cmd = new SqlCommand("SP_HUELLA_EMPLEADOS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lstEmpleados.Add(new CE_Huella_Empleado
                            {
                                Codigo = dr["COD_EMPLEADO"].ToString(),
                                Nombres = dr["NOMBRES"].ToString(),
                                Apellidos = dr["APELLIDOS"].ToString(),
                                Area = dr["AREA"].ToString(),
                                Huella = dr["HUELLA"] == DBNull.Value ? null : (byte[])dr["HUELLA"],
                                RutaImg = dr["RUTA_IMG"].ToString()
                            });
                        }
                    }

                }
            }

            return lstEmpleados;
        }

        public void GuardarMarcacion(CE_Huella_Empleado emp, SqlConnection cn)
        {
            //Conexion conexion = new Conexion();
            //SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                //using (cn = conexion.ConexionSql())
                //{
                //    cn.Open();
                    using (cmd = new SqlCommand("SP_INSERTAR_MARCACION", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@COD_EMPLEADO", emp.Codigo);

                        // EJECUTAR
                        cmd.ExecuteNonQuery();
                    }
                //}
            }
            catch (SqlException sqlEx)
            {
                //resultado = -1;
                //respuesta = "Error SQL : " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                //resultado = -1;
                //respuesta = "Error desconocido : " + ex.Message;
            }

            //return resultado;

        }

        public List<CE_Marcacion> ListarMarcaciones(CE_Huella_Empleado emp)
        {
            Conexion conexion = new Conexion();
            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            List<CE_Marcacion> lstMarcacion = new List<CE_Marcacion>();

            try
            {
                using (cn = conexion.ConexionSql())
                {
                    cn.Open();

                    GuardarMarcacion(emp, cn);

                    using (cmd = new SqlCommand("SP_OBTENER_MARCACIONES", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@COD_EMPLEADO", emp.Codigo);

                        using (dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lstMarcacion.Add(new CE_Marcacion
                                {
                                    Dia = dr["DIA"].ToString(),
                                    Fecha = Convert.ToDateTime(dr["FECHA"]),
                                    HoraIngreso = dr["HORA_ENTRADA"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)dr["HORA_ENTRADA"],
                                    HoraSalida = dr["HORA_SALIDA"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)dr["HORA_SALIDA"]
                                });
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {

            }

            return lstMarcacion;
        }

    }
}
