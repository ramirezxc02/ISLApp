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

        //metodo para registrar un infractor
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

                throw ex;
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

                throw ex;
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

                throw ex;
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

                throw ex;
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
                throw ex;
            }
        }

        public int cantidadEmpleadosActivos() {
            try
            {
                int cantidad = 0;
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "consulta_infractor_cedula";
                this.reader = this.command.ExecuteReader();
                cantidad = int.Parse(this.reader.GetValue(0).ToString());
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
    }
}
