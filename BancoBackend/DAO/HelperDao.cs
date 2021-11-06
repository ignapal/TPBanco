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
        private readonly SqlConnection connection;

        private HelperDao() {
            connection = new SqlConnection(@"Data Source=NBAR15229\SQLEXPRESS;Initial Catalog=BANCO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public static HelperDao GetInstancia() {
            if (instancia == null) {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public int GetUltimoId(string nombreSP,string nombreParam) {
            SqlCommand command = new(nombreSP, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new();
            parameter.SqlDbType = SqlDbType.Int;
            parameter.ParameterName = nombreParam;
            parameter.Direction = ParameterDirection.Output;

            try
            {
                connection.Open();
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
                return Convert.ToInt32(parameter.Value);
            }
            catch (Exception)
            {

                return 0;
            }
            finally {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public DataTable GetTable(string nombreSp,Dictionary<string,object> parametros) {

            SqlCommand command = new(nombreSp,connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                DataTable table = new();
                if (parametros.Count > 0)
                {
                    foreach (KeyValuePair<string, object> parametro in parametros)
                    {
                        command.Parameters.AddWithValue(parametro.Key, parametro.Value.ToString());
                    }
                }
                table.Load(command.ExecuteReader());
                connection.Close();
                return table;
            }
            catch (Exception)
            {
                return null;
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }
        public bool InsertarClienteConCuentas(string nombreSpMaestro, string nombreSpDetalle,Cliente cliente) {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = new(nombreSpMaestro,connection,transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@apellido", cliente.Apellido);
            command.Parameters.AddWithValue("@dni", cliente.Dni);

            try
            {
                
                command.ExecuteNonQuery();
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    SqlCommand commandDetalle = new(nombreSpDetalle,connection,transaction);
                    commandDetalle.CommandType = CommandType.StoredProcedure;
                    commandDetalle.Parameters.AddWithValue("@idCliente",cliente.IdCliente);
                    commandDetalle.Parameters.AddWithValue("@cbu", cuenta.Cbu);
                    commandDetalle.Parameters.AddWithValue("@saldo", cuenta.Saldo);
                    commandDetalle.Parameters.AddWithValue("@idTipoCuenta", cuenta.TipoCuenta);

                    commandDetalle.ExecuteNonQuery();
                }

                transaction.Commit();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;

            }
            finally {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public bool InsertarEntidad(string nombreSp,Dictionary<string,object> parametros) {

            SqlCommand command = new(nombreSp, connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                connection.Open();
                DataTable table = new();
                foreach (KeyValuePair<string, object> parametro in parametros)
                {
                    command.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
                command.ExecuteReader();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
