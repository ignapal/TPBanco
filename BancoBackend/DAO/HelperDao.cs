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

        public Cliente GetCliente() {
            SqlCommand command = new SqlCommand("SP_OBTENER_CLIENTE",connection);

            try
            {
                connection.Open();
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                connection.Close();

                Cliente cliente = new Cliente();
                cliente.Nombre = (string)table.Rows[0]["nombre"];
                cliente.Apellido = (string)table.Rows[0]["apellido"];
                cliente.Dni = Convert.ToInt32(table.Rows[0]["nroDoc"]);

                return cliente;
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
    }
}
