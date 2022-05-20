using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//driver para SQL Server
//using System.Data.SqlClient;

using Microsoft.Data.SqlClient;
//importacion del BLL
using BLL;

using System.Data;

namespace DAL
{
    public class Conexion
    {
        private SqlConnection conection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;

        //contenedor de datos
        private DataSet dataSet;

        //variable para almacenar el string de conexion
        private string strConexion;

        //constructor de la clase
        public Conexion(string strCnx)
        {
            this.strConexion = strCnx;
        }

        public void RegistrarReporte(Reporte reporte)
        {
            try
            {
                this.conection = new SqlConnection(this.strConexion);    
                this.conection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.conection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_Ins_Reporte]";

                //se asignan los valores a cada parametro de nuestro procedimiento almacenado
                this.command.Parameters.AddWithValue("@idInfractor", reporte.idInfractor);
                this.command.Parameters.AddWithValue("@funcionarioResponsable", reporte.funcionarioResponsable);
                this.command.Parameters.AddWithValue("@centroOperativo", reporte.centroOperativo);
                this.command.Parameters.AddWithValue("@codigoPresupuestario", reporte.codigoPresupuestario);
                this.command.Parameters.AddWithValue("@viatico", reporte.viatico);
                this.command.Parameters.AddWithValue("@horaInicio", reporte.horaInicio);
                this.command.Parameters.AddWithValue("@lugaresRecorridos", reporte.lugaresRecorridos);
                this.command.Parameters.AddWithValue("@horaFinalizacion", reporte.horaFinalizacion);
                this.command.Parameters.AddWithValue("@numeroOficio", reporte.numeroOficio);
                this.command.Parameters.AddWithValue("@accionDesarrollada", reporte.accionDesarrollada);
                this.command.Parameters.AddWithValue("@fechaReporte", reporte.fechaReporte);
                this.command.Parameters.AddWithValue("@recomendacion", reporte.recomendacion);
                this.command.Parameters.AddWithValue("@observacion", reporte.observacion);
                this.command.Parameters.AddWithValue("@matricula", reporte.matricula);
                this.command.Parameters.AddWithValue("@combustible", reporte.combustible);
                this.command.Parameters.AddWithValue("@kilometroInicio", reporte.kilometroInicio);
                this.command.Parameters.AddWithValue("@kilometroFinal", reporte.kilometroFinal);
                this.command.Parameters.AddWithValue("@placa", reporte.placa);
                this.command.Parameters.AddWithValue("@estado", reporte.estado);


                //se ejecuta el comando
                this.command.ExecuteNonQuery();

                //cierre de conexion
                this.conection.Close();

                //liberacion de recursos
                this.conection.Dispose();
                this.command.Dispose();



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificarReporte(Reporte reporte)
        {
            try
            {
                //se instancia la conex
                this.conection = new SqlConnection(this.strConexion);
                this.conection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.conection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_Modificar_Reporte]";

                this.command.Parameters.AddWithValue("@idReporte", reporte.idReporte);
                this.command.Parameters.AddWithValue("@idInfractor", reporte.idInfractor);
                this.command.Parameters.AddWithValue("@funcionarioResponsable", reporte.funcionarioResponsable);
                this.command.Parameters.AddWithValue("@centroOperativo", reporte.centroOperativo);
                this.command.Parameters.AddWithValue("@codigoPresupuestario", reporte.codigoPresupuestario);
                this.command.Parameters.AddWithValue("@viatico", reporte.viatico);
                this.command.Parameters.AddWithValue("@horaInicio", reporte.horaInicio);
                this.command.Parameters.AddWithValue("@lugaresRecorridos", reporte.lugaresRecorridos);
                this.command.Parameters.AddWithValue("@horaFinalizacion", reporte.horaFinalizacion);
                this.command.Parameters.AddWithValue("@numeroOficio", reporte.numeroOficio);
                this.command.Parameters.AddWithValue("@accionDesarrollada", reporte.accionDesarrollada);
                this.command.Parameters.AddWithValue("@fechaReporte", reporte.fechaReporte);
                this.command.Parameters.AddWithValue("@recomendacion", reporte.recomendacion);
                this.command.Parameters.AddWithValue("@observacion", reporte.observacion);
                this.command.Parameters.AddWithValue("@matricula", reporte.matricula);
                this.command.Parameters.AddWithValue("@combustible", reporte.combustible);
                this.command.Parameters.AddWithValue("@kilometroInicio", reporte.kilometroInicio);
                this.command.Parameters.AddWithValue("@kilometroFinal", reporte.kilometroFinal);
                this.command.Parameters.AddWithValue("@placa", reporte.placa);

                this.command.ExecuteNonQuery();
                this.conection.Close();
                this.command.Dispose();
                this.conection.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 

        public DataSet BuscarReporte(string criterio)
        {
            try
            {
                //se instancia una conexion
                this.conection = new SqlConnection(this.strConexion);
                //se intenta abrir
                this.conection.Open();
                //se instancia el comando
                this.command = new SqlCommand();
                //se asigna la conexion al comando
                this.command.Connection = this.conection;
                //se indica el tipo de comando
                this.command.CommandType = CommandType.StoredProcedure;
                //se indica el nombre del procedimiento almacenado 
                this.command.CommandText = "[Sp_BuscarReporte]";
                //asignamos el valor al parametro del procedimiento
                this.command.Parameters.AddWithValue("@criterio", criterio);
                //se instancia un adaptador
                this.dataAdapter = new SqlDataAdapter();
                //se instancia el comando al adaptador
                this.dataAdapter.SelectCommand = this.command;
                //se instancia un dataset con los datos del comando
                this.dataSet = new DataSet();
                //se llena el data set con los datos del comando
                this.dataAdapter.Fill(this.dataSet);
                //se cierran los recursos
                this.conection.Close();
                //se liberan los recursosr
                this.conection.Dispose();
                this.command.Dispose();
                this.dataAdapter.Dispose();

                //se retorna el DataSet
                return this.dataSet;




            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public DataSet MostrarReporte()
        {
            try
            {
                //se instancia una conexion
                this.conection = new SqlConnection(this.strConexion);
                //se intenta abrir
                this.conection.Open();
                //se instancia el comando
                this.command = new SqlCommand();
                //se asigna la conexion al comando
                this.command.Connection = this.conection;
                //se indica el tipo de comando
                this.command.CommandType = CommandType.StoredProcedure;
                //se indica el nombre del procedimiento almacenado 
                this.command.CommandText = "[Sp_MostrarReporte]";
                //asignamos el valor al parametro del procedimiento
               // this.command.Parameters.AddWithValue("@numeroOficio", numOficio);
                //se instancia un adaptador
                this.dataAdapter = new SqlDataAdapter();
                //se instancia el comando al adaptador
                this.dataAdapter.SelectCommand = this.command;
                //se instancia un dataset con los datos del comando
                this.dataSet = new DataSet();
                //se llena el data set con los datos del comando
                this.dataAdapter.Fill(this.dataSet);
                //se cierran los recursos
                this.conection.Close();
                //se liberan los recursosr
                this.conection.Dispose();
                this.command.Dispose();
                this.dataAdapter.Dispose();

                //se retorna el DataSet
                return this.dataSet;
            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public Reporte BuscarReportePorIDReporte(int pIdReporte)
        {         
            try
            {
                Reporte temp = null;

                this.conection = new SqlConnection(this.strConexion);
                this.conection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.conection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_BuscarReportePorIDReporte]";
                //se asigna el valor al parametro
                this.command.Parameters.AddWithValue("@idReporte", pIdReporte);

                //muy importe el comando es de lectura ExecuteReader
                this.dataReader = this.command.ExecuteReader();

                //se pregunta si el lector tiene datos
                if (this.dataReader.Read())
                {
                    //se crea una instancia del obj usuario
                    temp = new Reporte();

                    //rellenamos el obj con los datos que nos retorna el proce almacenado
                    temp.idInfractor = int.Parse(this.dataReader.GetValue(0).ToString());
                    temp.centroOperativo = this.dataReader.GetValue(1).ToString();
                    temp.codigoPresupuestario = this.dataReader.GetValue(2).ToString();
                    temp.viatico = int.Parse(this.dataReader.GetValue(3).ToString());
                    temp.horaInicio = this.dataReader.GetValue(4).ToString();
                    temp.lugaresRecorridos = this.dataReader.GetValue(5).ToString();
                    temp.horaFinalizacion = this.dataReader.GetValue(6).ToString();
                    temp.accionDesarrollada = this.dataReader.GetValue(7).ToString();
                    temp.fechaReporte = this.dataReader.GetValue(8).ToString();
                    temp.recomendacion = this.dataReader.GetValue(9).ToString();
                    temp.observacion = this.dataReader.GetValue(10).ToString();
                    temp.matricula = this.dataReader.GetValue(11).ToString();
                    temp.combustible = int.Parse(this.dataReader.GetValue(12).ToString());
                    temp.kilometroInicio = this.dataReader.GetValue(13).ToString();
                    temp.kilometroFinal = this.dataReader.GetValue(14).ToString();
                    temp.placa = this.dataReader.GetValue(15).ToString();
                }
                //cerrar la conexion
                this.conection.Close();

                //liberacion de recursos
                this.conection.Dispose();
                this.command.Dispose();
                this.dataReader = null;

                return temp;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





    }


}