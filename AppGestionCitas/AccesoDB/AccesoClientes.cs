using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppGestionCitas.AccesoDB
{
    class AccesoClientes
    {
        public static List<CClientes> ObtenerClientes()
        {
            try
            {
                List<CClientes> listaClientes = new List<CClientes>();
                using (SqlConnection connection = new SqlConnection(CConstantes.connString))
                {
                    connection.Open();

                    String sql = "SELECT Clientes.Id, Clientes.Cliente, Clientes.Direccion, Clientes.Pais, Clientes.IdComunidad, Comunidades.Nombre AS Comunidad, Clientes.IdProvincia, Provincias.Nombre AS Provincia, Localidad, CP, DNI, Telefono " +
                                 "FROM Clientes INNER JOIN Comunidades ON Clientes.IdComunidad = Comunidades.Id " +
                                 "INNER JOIN Provincias ON Clientes.IdProvincia = Provincias.Id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {                            
                            while (reader.Read())
                            {
                                CClientes cliente = new CClientes();

                                cliente.id = Convert.ToInt32(reader["Id"]);
                                cliente.cliente = reader["Cliente"].ToString();
                                cliente.direccion = reader["Direccion"].ToString();
                                cliente.pais = reader["Pais"].ToString();
                                cliente.idComunidad = Convert.ToInt32(reader["IdComunidad"]);
                                cliente.comunidad = reader["Comunidad"].ToString();
                                cliente.idProvincia = Convert.ToInt32(reader["IdProvincia"]);
                                cliente.provincia = reader["Provincia"].ToString();
                                cliente.localidad = reader["Localidad"].ToString();
                                cliente.cp = reader["CP"].ToString();
                                cliente.telefono = reader["Telefono"].ToString();
                                cliente.dni = reader["DNI"].ToString();

                                listaClientes.Add(cliente);
                            }
                        }
                    }

                    connection.Close();
                    return listaClientes;
                }
            }
            catch (SqlException e)
            {
                XtraMessageBox.Show("Error en el acceso a la base de datos. " + e.Message, "Acceso datos", MessageBoxButtons.OK);
                return null;
            }
        }

        public static bool InsertarCliente(CClientes cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CConstantes.connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO Clientes(Cliente, Direccion, Pais, IdComunidad, IdProvincia, Localidad, CP, DNI, Telefono) 
                            VALUES(@param1,@param2,@param3, @param4, @param5, @param6, @param7, @param8, @param9)";

                        cmd.Parameters.AddWithValue("@param1", cliente.cliente);
                        cmd.Parameters.AddWithValue("@param2", cliente.direccion);
                        cmd.Parameters.AddWithValue("@param3", cliente.pais);
                        cmd.Parameters.AddWithValue("@param4", cliente.idComunidad);
                        cmd.Parameters.AddWithValue("@param5", cliente.idProvincia);
                        cmd.Parameters.AddWithValue("@param6", cliente.localidad);
                        cmd.Parameters.AddWithValue("@param7", cliente.cp);
                        cmd.Parameters.AddWithValue("@param8", cliente.dni);
                        cmd.Parameters.AddWithValue("@param9", cliente.telefono);

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
        public static bool BorrarCliente(Int64 idCliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CConstantes.connString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"DELETE FROM Clientes WHERE Id = @param1";

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

    public class CClientes
    {
        public int id { get; set; }
        public string cliente { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }
        public int idComunidad { get; set; }
        public string comunidad { get; set; }
        public int idProvincia { get; set; }
        public string provincia { get; set; }
        public string localidad { get; set; }
        public string cp { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
    }
}
