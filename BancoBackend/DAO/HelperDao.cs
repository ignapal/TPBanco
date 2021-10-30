using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BancoBackend.Entidades;
using System.Data;

namespace BancoBackend.DAO
{
    class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection connection;

        private HelperDao() {
            connection = new SqlConnection(@"Data Source=NBAR15229\SQLEXPRESS;Initial Catalog=BANCO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public static HelperDao GetInstancia() {
            if (instancia == null) {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public DataTable GetTable(string nombreSp,Dictionary<string,object> parametros) {

            SqlCommand command = new SqlCommand(nombreSp,connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                DataTable table = new DataTable();
                foreach (KeyValuePair<string, object> parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key,parametro.Value.ToString());
                }
                table.Load(command.ExecuteReader());
                connection.Close();
                return table;
            }
            catch (Exception e)
            {
                
                return null;
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        public bool InsertarCliente(Cliente cliente) {
            bool ok = true;

            SqlCommand command = new SqlCommand("SP_INSERTAR_CLIENTE", connection);
            command.CommandType = CommandType.StoredProcedure;

            //Parametros
            command.Parameters.AddWithValue("@nombre",cliente.Nombre);
            command.Parameters.AddWithValue("@apellido",cliente.Apellido);
            command.Parameters.AddWithValue("@dni",cliente.Dni);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                string mes = e.Message;
                ok = false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return ok;
        }
    }
}
