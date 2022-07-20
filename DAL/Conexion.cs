using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private SqlDataReader reader;

        private DataSet dataset;

        // variable para almacenar el string de conexion
        private string strConexion;
        public Conexion(string strCnx) {
            this.strConexion = strCnx;
        }

        public Boolean realizarConexion() {
            try
            {
                Boolean conexionEstablecida = false;
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                if ((connection.State & ConnectionState.Open) > 0) {
                    conexionEstablecida = true;
                }
                return conexionEstablecida;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexion no establecida" + ex);
                return false;
            }
        }
        // metodos que recibe como parametros un infractor y realiza un llamado a un stored procedured de la base de datos
        // que permite realizar un insert
        public void registrarInfractor(InfractorBD infractor) 
        {
            try
            {
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "insertar_infractor";
                this.command.Parameters.AddWithValue("@nombreResponsable", infractor.nombreResponsable);
                this.command.Parameters.AddWithValue("@cedulaResponsable", infractor.cedulaResponsable);
                this.command.Parameters.AddWithValue("@tipoResponsable", infractor.tipoResponsable);
                this.command.Parameters.AddWithValue("@estado", infractor.estado);
                this.command.ExecuteNonQuery();
                this.command.Parameters.Clear();
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar la consulta en la base de datos" +ex);
            }
        }

        public int buscarInfractorXcedula(String cedula) {
            try
            {
                int cantidad = 0;
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "consulta_infractor_cedula";
                this.command.Parameters.AddWithValue("@cedulaResponsable", cedula);
                this.reader = this.command.ExecuteReader();
                if (this.reader.Read()) {
                    cantidad = int.Parse(this.reader.GetValue(0).ToString());
                }
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();

                return cantidad;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable consultaInfractores() {
            try
            {
                DataTable temp = new DataTable();
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[consultaInfractores]";

                this.adapter = new SqlDataAdapter();
                adapter.SelectCommand = this.command;
                adapter.Fill(temp);
                this.connection.Close();
                this.connection.Dispose();
                this.adapter.Dispose();

                return temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al realizar la consulta de la base de datos" +ex);
                DataTable temp = new DataTable();
                return temp;
            }
        }

        public DataTable busqueda(String criterio) {
            try
            {
                DataTable temp = new DataTable();
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[busqueda]";
                this.command.Parameters.AddWithValue("@criterio", criterio);

                this.adapter = new SqlDataAdapter();
                adapter.SelectCommand = this.command;
                adapter.Fill(temp);
                this.connection.Close();
                this.connection.Dispose();
                this.adapter.Dispose();

                return temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al realizar la consulta en la base" +ex);
                DataTable temp = new DataTable();
                return temp;
            }
        }

        public void modificar(InfractorBD infractor, int idModificacion)
        {
            try
            {
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "modificarInfractor";
                this.command.Parameters.AddWithValue("@cedulaResponsable", infractor.cedulaResponsable);
                this.command.Parameters.AddWithValue("@nombreResponsable", infractor.nombreResponsable);
                this.command.Parameters.AddWithValue("@tipoResponsable", infractor.tipoResponsable);
                this.command.Parameters.AddWithValue("@idResponsable", idModificacion);
                this.command.ExecuteNonQuery();
                this.command.Parameters.Clear();
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {
               Console.WriteLine("Error en la consulta de la base de datos" + ex);
            }
        }
        public void deshabilitar( int identificador)
        {
            try
            {
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "deshabilitarInfractor";
                this.command.Parameters.AddWithValue("@identificador", identificador);
                this.command.ExecuteNonQuery();
                this.command.Parameters.Clear();
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la consulta de la base de datos" + ex);
            }
        }

        public int cantidadInfractoresActivos() {
            try
            {
                int cantidad = 0;
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "cantidadInfractorActivos";
                this.reader = this.command.ExecuteReader();
                if (this.reader.Read())
                {
                    cantidad = int.Parse(this.reader.GetValue(0).ToString());
                }
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();

                return cantidad;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error al consultar la base de datos" + ex);
                return 0;
            }
        }
    }
}
