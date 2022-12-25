using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionCitas.AccesoDB
{
    class AccesoComunidades
    {
        public static List<CComunidades> ObtenerComunidades()
        {
            try
            {
                List<CComunidades> listaComunidades = new List<CComunidades>();
                using (SqlConnection connection = new SqlConnection(CConstantes.connString))
                {
                    connection.Open();

                    String sql = "SELECT Id, Nombre " +
                                 "FROM Comunidades ";
                    
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {                            
                            while (reader.Read())
                            {
                                CComunidades comunidad = new CComunidades();

                                comunidad.id = Convert.ToInt32(reader["Id"]);
                                comunidad.nombre = reader["Nombre"].ToString();

                                listaComunidades.Add(comunidad);
                            }                            
                        }
                    }

                    connection.Close();
                    return listaComunidades;
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return null;
            }            
        }
    }

    public class CComunidades
    {
        public int id { get; set; }
        public string nombre { get; set; }        
    }
}
