using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDal
    {
        private Acceso ac;

        public UsuarioDal()
        {
            ac = new Acceso();
        }
        public Usuario Buscar(Usuario user)
        {
            Usuario us = null;

            string consulta = @"SELECT Nombre, Pass, TipoUsuario 
                    FROM Usuario 
                    WHERE Nombre = @user AND Pass = @pass";

            using (SqlConnection conn = new SqlConnection("Initial Catalog=ProyectoWEB;Data Source=.;Integrated Security=SSPI;"))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    // Asegurate de que no agregás este parámetro más de una vez
                    cmd.Parameters.AddWithValue("@user", user.USERNAME);
                    cmd.Parameters.AddWithValue("@pass", user.Clave);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string passwordBD = reader["Pass"].ToString();

                            if (passwordBD == user.Clave)
                            {
                                us = new Usuario();
                                us.USERNAME = reader["Nombre"].ToString();
                                us.Clave = passwordBD;
                                int tipo = Convert.ToInt32(reader["TipoUsuario"]);
                                us.TipoUser = tipo;
                                
                            }
                        }
                    }
                }
            }

            return us;
        }




        //else

        ////int intentos = int.Parse(tabla.Rows[0]["intentos"].ToString());
        ///parametros = new List<SqlParameter>();
        ///parametros.Add(new SqlParameter("@usu", user));
        ///ac.Escribir("USUARIO_INCREMENTAR_INTENTO", parametros);
        ///if (intentos +1 >= 3)
        ///{
        ///parametros = new List<SqlParameter>();
        //////parametros.Add(new SqlParameter("@usu", user));
        ///ac.Escribir("USUARIO_Bloquear", parametros);



    }
}




            
        
    
 
