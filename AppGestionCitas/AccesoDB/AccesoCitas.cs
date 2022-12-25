using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCitas.AccesoDB
{
    class AccesoCitas
    {
        public static List<CCitas> ObtenerCitas()
        {
            try
            {
                List<CCitas> listaCitas = new List<CCitas>();
                using (SqlConnection connection = new SqlConnection(CConstantes.connString))
                {
                    connection.Open();

                    String sql = "SELECT Citas.Id, Citas.IdCliente, Clientes.Cliente AS Nombre, Citas.InicioCita, Citas.FinCita, Citas.Estado " +
                                 "FROM Citas INNER JOIN Clientes ON Citas.IdCliente = Clientes.Id ";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CCitas citas = new CCitas();

                                citas.id = Convert.ToInt32(reader["Id"]);
                                citas.idCliente = Convert.ToInt32(reader["IdCliente"]);
                                citas.nombre = reader["Nombre"].ToString();
                                citas.inicioCita = Convert.ToDateTime(reader["InicioCita"]);
                                citas.finCita = Convert.ToDateTime(reader["FinCita"]);
                                citas.estado =Convert.ToBoolean(reader["Estado"]);

                                listaCitas.Add(citas);
                            }
                        }
                    }

                    connection.Close();
                    return listaCitas;
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return null;
            }
        }

        public static List<CCitas> ObtenerCitasPorClienteEstado(int idCliente, bool estado)
        {
            try
            {
                List<CCitas> listaCitas = new List<CCitas>();
                using (SqlConnection connection = new SqlConnection(CConstantes.connString))
                {
                    connection.Open();

                    String sql = "SELECT Citas.Id, Citas.IdCliente, Clientes.Cliente AS Nombre, Citas.InicioCita, Citas.FinCita, Citas.Estado " +
                                 "FROM Citas INNER JOIN Clientes ON Citas.IdCliente = Clientes.Id WHERE Citas.Id = @param1 AND Citas.Estado = @param2";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@param1", idCliente);
                        command.Parameters.AddWithValue("@param2", estado);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CCitas citas = new CCitas();

                                citas.id = Convert.ToInt32(reader["Id"]);
                                citas.idCliente = Convert.ToInt32(reader["IdCliente"]);
                                citas.nombre = reader["Nombre"].ToString();
                                citas.inicioCita = Convert.ToDateTime(reader["InicioCita"]);
                                citas.finCita = Convert.ToDateTime(reader["FinCita"]);
                                citas.estado = Convert.ToBoolean(reader["IdComunidad"]);

                                listaCitas.Add(citas);
                            }
                        }
                    }

                    connection.Close();
                    return listaCitas;
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return null;
            }
        }

        public static List<CCitas> ObtenerCitasEstado(bool estado)
        {
            try
            {
                List<CCitas> listaCitas = new List<CCitas>();
                using (SqlConnection connection = new SqlConnection(CConstantes.connString))
                {
                    connection.Open();

                    String sql = "SELECT Citas.Id, Citas.IdCliente, Clientes.Cliente AS Nombre, Citas.InicioCita, Citas.FinCita, Citas.Estado " +
                                 "FROM Citas INNER JOIN Clientes ON Citas.IdCliente = Clientes.Id WHERE estado = @param1";


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@param1", estado);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CCitas citas = new CCitas();

                                citas.id = Convert.ToInt32(reader["Id"]);
                                citas.idCliente = Convert.ToInt32(reader["IdCliente"]);
                                citas.nombre = reader["Nombre"].ToString();
                                citas.inicioCita = Convert.ToDateTime(reader["InicioCita"]);
                                citas.finCita = Convert.ToDateTime(reader["FinCita"]);
                                citas.estado = Convert.ToBoolean(reader["Estado"]);

                                listaCitas.Add(citas);
                            }
                        }
                    }

                    connection.Close();
                    return listaCitas;
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return null;
            }
        }

        public static bool InsertarCita(CCitas cita)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CConstantes.connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO Citas(IdCliente, InicioCita, FinCita, Estado) 
                            VALUES(@param1,@param2,@param3, @param4)";

                        cmd.Parameters.AddWithValue("@param1", cita.idCliente);
                        cmd.Parameters.AddWithValue("@param2", cita.inicioCita);
                        cmd.Parameters.AddWithValue("@param3", cita.finCita);
                        cmd.Parameters.AddWithValue("@param4", cita.estado);


                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool ActualizarCita(int idCita)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CConstantes.connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"UPDATE Citas SET estado = 1 WHERE id = @param1";

                        cmd.Parameters.AddWithValue("@param1", idCita);


                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool BorrarCitaId(Int64 id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CConstantes.connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"DELETE FROM Citas WHERE Id = @param1";

                        cmd.Parameters.AddWithValue("@param1", id);


                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return false;
            }
        }
        public static bool BorrarCitasCliente(Int64 idCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CConstantes.connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"DELETE FROM Citas WHERE IdCliente = @param1";

                        cmd.Parameters.AddWithValue("@param1", idCliente);


                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return false;
            }
        }
    }
    public class CCitas
    {
        public int id { get; set; }
        public Int64 idCliente { get; set; }
        public string nombre { get; set; }
        public DateTime inicioCita { get; set; }
        public DateTime finCita { get; set; }
        public bool estado { get; set; }

    }
}
