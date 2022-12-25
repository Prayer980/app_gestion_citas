using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionCitas.AccesoDB
{
    class AccesoProvincias
    {
        public static List<CProvincias> ObtenerProvincias()
        {
            try
            {
                List<CProvincias> listaProvincias = new List<CProvincias>();
                using (SqlConnection connection = new SqlConnection(CConstantes.connString))
                {
                    connection.Open();

                    String sql = "SELECT Id, Nombre " +
                                 "FROM Provincias ";

                    MessageBox.Show("Sql: " + sql);

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CProvincias provincia = new CProvincias();

                                provincia.id = Convert.ToInt32(reader["Id"]);
                                provincia.nombre = reader["Nombre"].ToString();

                                listaProvincias.Add(provincia);
                            }                            
                        }
                    }

                    connection.Close();
                    return listaProvincias;
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return null;
            }            
        }
    }

    public class CProvincias
    {
        public int id { get; set; }
        public string nombre { get; set; }        
    }
}
