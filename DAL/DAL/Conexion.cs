using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class Conexion
    {

        //variables globales
        private SqlConnection conection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;

        private DataSet dataSet;//contenedor de datos

        //variable para almacenar el string de conexion
        private string strConexion;

        //constructor de la clase
        public Conexion(string strCnx)
        {
            this.strConexion = strCnx;
        }

        public void registrarUsuario(Usuario usuario)
        {
            try
            {
                //se inicializan las variables
                this.conection = new SqlConnection(strConexion);
                this.conection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.conection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_RegistarUsuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                this.command.Parameters.AddWithValue("@email", usuario.email);
                this.command.Parameters.AddWithValue("@password", usuario.password);
                this.command.Parameters.AddWithValue("@rol", usuario.rol);
                //se ejecuta el comando
                this.command.ExecuteNonQuery();
                //se cierra la conexion y se liberan los recursos
                this.conection.Close();
                this.conection.Dispose();
                this.command.Dispose();  
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                //se inicializan las variables
                this.conection = new SqlConnection(strConexion);
                this.conection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.conection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_ActualizarUsuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                this.command.Parameters.AddWithValue("@email", usuario.email);
                this.command.Parameters.AddWithValue("@rol", usuario.rol);
                //se ejecuta el comando
                this.command.ExecuteNonQuery();
                //se cierra la conexion y se liberan los recursos
                this.conection.Close();
                this.conection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            try
            {
                //se inicializan las variables
                this.conection = new SqlConnection(strConexion);
                this.conection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.conection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_EliminarUsuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                //se ejecuta el comando
                this.command.ExecuteNonQuery();
                //se cierra la conexion y se liberan los recursos
                this.conection.Close();
                this.conection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet BuscarUsuario(string nombreUsuario)
        {
            try
            {
                this.conection = new SqlConnection(this.strConexion);              
                this.conection.Open();            
                this.command = new SqlCommand();               
                this.command.Connection = this.conection;              
                this.command.CommandType = CommandType.StoredProcedure;              
                this.command.CommandText = "[Sp_Cns_Usuario]";             
                this.command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);             
                this.dataAdapter = new SqlDataAdapter();               
                this.dataAdapter.SelectCommand = this.command;             
                this.dataSet = new DataSet();            
                this.dataAdapter.Fill(this.dataSet);
                this.conection.Close();
                
                this.conection.Dispose();
                this.command.Dispose();
                this.dataAdapter.Dispose();
                
                return this.dataSet;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }


    

    }//cierre de clase
}//cierre de namespace
