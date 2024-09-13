using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Permiso
    {

        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> Lista = new List<Permiso>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))


                    {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol, p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");

           
                    using (SqlCommand cmd = new SqlCommand(query.ToString(), oconexion))
                    {
                        cmd.Parameters.AddWithValue("@idusuario", idUsuario);
                        cmd.CommandType = CommandType.Text;

                        oconexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Lista.Add(new Permiso()
                                {
                                    oRol = new Rol(){ IdRol = Convert.ToInt32(dr["IdRol"]) },
                                    NombreMenu = dr["NombreMenu"].ToString(),
                                  
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Lista = new List<Permiso>();
            }

            return Lista;
        }



    }
}
