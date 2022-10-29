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
                this.command.CommandText = "[insertar_infractor]";
                this.command.Parameters.AddWithValue("@nombreResponsable", infractor.nombreResponsable);
                this.command.Parameters.AddWithValue("@cedulaResponsable", infractor.cedulaResponsable);
                this.command.Parameters.AddWithValue("@tipoResponsable", infractor.tipoResponsable);
                this.command.Parameters.AddWithValue("@estado", infractor.estado);
                this.command.Parameters.AddWithValue("@actividadIlegal", infractor.actividadIlegal);
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
                this.command.CommandText = "[consulta_infractor_cedula]";
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
                this.command.CommandText = "[deshabilitarInfractor]";
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
                this.command.CommandText = "[cantidadInfractorActivos]";
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
        public int buscarActividadXnombre(String nombre)
        {
            try
            {
                int id = 0;
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[consultaActividadXNombre]";
                this.command.Parameters.AddWithValue("@nombreActividad", nombre);
                this.reader = this.command.ExecuteReader();
                if (this.reader.Read())
                {
                    id = int.Parse(this.reader.GetValue(0).ToString());
                }
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();

                return id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void registrarUsuario(Usuario usuario)
        {
            try
            {
                //se inicializan las variables
                this.connection = new SqlConnection(strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_RegistarUsuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                this.command.Parameters.AddWithValue("@email", usuario.email);
                this.command.Parameters.AddWithValue("@password", usuario.password);
                this.command.Parameters.AddWithValue("@rol", usuario.rol);
                //se ejecuta el comando
                this.command.ExecuteNonQuery();
                //se cierra la conexion y se liberan los recursos
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarUsuario(string username, Usuario usuario)
        {
            try
            {
                //se inicializan las variables
                this.connection = new SqlConnection(strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_ActualizarUsuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                this.command.Parameters.AddWithValue("@password", usuario.password);
                this.command.Parameters.AddWithValue("@email", usuario.email);
                this.command.Parameters.AddWithValue("@rol", usuario.rol);
                this.command.Parameters.AddWithValue("@username", username);
                //se ejecuta el comando
                this.command.ExecuteNonQuery();
                //se cierra la conexion y se liberan los recursos
                this.connection.Close();
                this.connection.Dispose();
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
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_Cns_Usuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                this.adapter = new SqlDataAdapter();
                this.adapter.SelectCommand = this.command;
                this.dataset = new DataSet();
                this.adapter.Fill(this.dataset);
                this.connection.Close();

                this.connection.Dispose();
                this.command.Dispose();
                this.adapter.Dispose();

                return this.dataset;
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
                this.connection = new SqlConnection(strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_EliminarUsuario]";
                this.command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                //se ejecuta el comando
                this.command.ExecuteNonQuery();
                //se cierra la conexion y se liberan los recursos
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataSet Login(string nombreUsuario)
        {
            try
            {
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_Login]";
                this.command.Parameters.AddWithValue("@username", nombreUsuario);
                this.adapter = new SqlDataAdapter();
                this.adapter.SelectCommand = this.command;
                this.dataset = new DataSet();
                this.adapter.Fill(this.dataset);
                this.connection.Close();
                this.connection.Dispose();
                this.command.Dispose();
                this.adapter.Dispose();

                return this.dataset;
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int numeroReporte()
        {
            try
            {
                int numeroReporte = 0;

                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[NumeroReporte]";
                //se asigna el valor al parametro
                // this.command.Parameters.AddWithValue("@idReporte", pIdReporte);

                //muy importe el comando es de lectura ExecuteReader
                this.reader = this.command.ExecuteReader();

                //se pregunta si el lector tiene datos
                if (this.reader.Read())
                {
                    //rellenamos el obj con los datos que nos retorna el proce almacenado
                    numeroReporte = int.Parse(this.reader.GetValue(0).ToString());
                }
                //cerrar la conexion
                this.connection.Close();

                //liberacion de recursos
                this.connection.Dispose();
                this.command.Dispose();
                this.reader = null;

                return numeroReporte;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public void registrarReporte(Reporte reporte)
        {
            try
            {
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
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
                this.command.Parameters.AddWithValue("@numeroFuncionariosSINAC", reporte.numeroFuncionariosSINAC);
                this.command.Parameters.AddWithValue("@numeroFuncionariosOtrasInstituciones", reporte.numeroFuncionariosOtrasInstituciones);




                //se ejecuta el comando
                this.command.ExecuteNonQuery();

                //cierre de conexion
                this.connection.Close();

                //liberacion de recursos
                this.connection.Dispose();
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
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.connection;
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
                this.command.Parameters.AddWithValue("@accionDesarrollada", reporte.accionDesarrollada);
                this.command.Parameters.AddWithValue("@fechaReporte", reporte.fechaReporte);
                this.command.Parameters.AddWithValue("@recomendacion", reporte.recomendacion);
                this.command.Parameters.AddWithValue("@observacion", reporte.observacion);
                this.command.Parameters.AddWithValue("@matricula", reporte.matricula);
                this.command.Parameters.AddWithValue("@combustible", reporte.combustible);
                this.command.Parameters.AddWithValue("@kilometroInicio", reporte.kilometroInicio);
                this.command.Parameters.AddWithValue("@kilometroFinal", reporte.kilometroFinal);
                this.command.Parameters.AddWithValue("@placa", reporte.placa);
                this.command.Parameters.AddWithValue("@numeroFuncionariosSINAC", reporte.numeroFuncionariosSINAC);
                this.command.Parameters.AddWithValue("@numeroFuncionariosOtrasInstituciones", reporte.numeroFuncionariosOtrasInstituciones);



                this.command.ExecuteNonQuery();
                this.connection.Close();
                this.command.Dispose();
                this.connection.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet buscarReporte(string criterio)
        {
            try
            {
                //se instancia una conexion
                this.connection = new SqlConnection(this.strConexion);
                //se intenta abrir
                this.connection.Open();
                //se instancia el comando
                this.command = new SqlCommand();
                //se asigna la conexion al comando
                this.command.Connection = this.connection;
                //se indica el tipo de comando
                this.command.CommandType = CommandType.StoredProcedure;
                //se indica el nombre del procedimiento almacenado 
                this.command.CommandText = "[Sp_BuscarReporte]";
                //asignamos el valor al parametro del procedimiento
                this.command.Parameters.AddWithValue("@criterio", criterio);
                //se instancia un adaptador
                this.adapter = new SqlDataAdapter();
                //se instancia el comando al adaptador
                this.adapter.SelectCommand = this.command;
                //se instancia un dataset con los datos del comando
                this.dataset = new DataSet();
                //se llena el data set con los datos del comando
                this.adapter.Fill(this.dataset);
                //se cierran los recursos
                this.connection.Close();
                //se liberan los recursosr
                this.connection.Dispose();
                this.command.Dispose();
                this.adapter.Dispose();

                //se retorna el DataSet
                return this.dataset;




            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public DataSet mostrarReporte()
        {
            try
            {
                //se instancia una conexion
                this.connection = new SqlConnection(this.strConexion);
                //se intenta abrir
                this.connection.Open();
                //se instancia el comando
                this.command = new SqlCommand();
                //se asigna la conexion al comando
                this.command.Connection = this.connection;
                //se indica el tipo de comando
                this.command.CommandType = CommandType.StoredProcedure;
                //se indica el nombre del procedimiento almacenado 
                this.command.CommandText = "[Sp_MostrarReporte]";
                //asignamos el valor al parametro del procedimiento
                // this.command.Parameters.AddWithValue("@numeroOficio", numOficio);
                //se instancia un adaptador
                this.adapter = new SqlDataAdapter();
                //se instancia el comando al adaptador
                this.adapter.SelectCommand = this.command;
                //se instancia un dataset con los datos del comando
                this.dataset = new DataSet();
                //se llena el data set con los datos del comando
                this.adapter.Fill(this.dataset);
                //se cierran los recursos
                this.connection.Close();
                //se liberan los recursosr
                this.connection.Dispose();
                this.command.Dispose();
                this.adapter.Dispose();

                //se retorna el DataSet
                return this.dataset;
            }

            catch (Exception ex)
            {

                throw;
            }
        }

        public Reporte buscarReportePorIDReporte(int pIdReporte)
        {
            try
            {
                Reporte temp = null;

                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();

                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_BuscarReportePorIDReporte]";
                //se asigna el valor al parametro
                this.command.Parameters.AddWithValue("@idReporte", pIdReporte);

                //muy importe el comando es de lectura ExecuteReader
                this.reader = this.command.ExecuteReader();

                //se pregunta si el lector tiene datos
                if (this.reader.Read())
                {
                    //se crea una instancia del obj usuario
                    temp = new Reporte();

                    //rellenamos el obj con los datos que nos retorna el proce almacenado
                    temp.idInfractor = int.Parse(this.reader.GetValue(0).ToString());
                    temp.centroOperativo = this.reader.GetValue(1).ToString();
                    temp.codigoPresupuestario = this.reader.GetValue(2).ToString();
                    temp.viatico = int.Parse(this.reader.GetValue(3).ToString());
                    temp.horaInicio = this.reader.GetValue(4).ToString();
                    temp.lugaresRecorridos = this.reader.GetValue(5).ToString();
                    temp.horaFinalizacion = this.reader.GetValue(6).ToString();
                    temp.numeroOficio = this.reader.GetValue(7).ToString();
                    temp.accionDesarrollada = this.reader.GetValue(8).ToString();
                    temp.fechaReporte = this.reader.GetValue(9).ToString();
                    temp.recomendacion = this.reader.GetValue(10).ToString();
                    temp.observacion = this.reader.GetValue(11).ToString();
                    temp.matricula = this.reader.GetValue(12).ToString();
                    temp.combustible = int.Parse(this.reader.GetValue(13).ToString());
                    temp.kilometroInicio = this.reader.GetValue(14).ToString();
                    temp.kilometroFinal = this.reader.GetValue(15).ToString();
                    temp.placa = this.reader.GetValue(16).ToString();
                    temp.numeroFuncionariosSINAC = int.Parse(this.reader.GetValue(17).ToString());
                    temp.numeroFuncionariosOtrasInstituciones = int.Parse(this.reader.GetValue(18).ToString());
                    temp.idReporte = int.Parse(this.reader.GetValue(19).ToString());



                }
                //cerrar la conexion
                this.connection.Close();

                //liberacion de recursos
                this.connection.Dispose();
                this.command.Dispose();
                this.reader = null;

                return temp;
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }
        public void deshabilitarReporte(int idReporte)
        {
            try
            {
                this.connection = new SqlConnection(this.strConexion);
                this.connection.Open();
                this.command = new SqlCommand();
                this.command.Connection = this.connection;
                this.command.CommandType = CommandType.StoredProcedure;
                this.command.CommandText = "[Sp_DeshabilitarReporte]";
                this.command.Parameters.AddWithValue("@idReporte", idReporte);
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


        public DataSet BuscarInfractor(string pNombre)
        {
            try
            {
                //se instancia una conexion
                this.connection = new SqlConnection(this.strConexion);
                //se intenta abrir
                this.connection.Open();
                //se instancia el comando
                this.command = new SqlCommand();
                //se asigna la conexion al comando
                this.command.Connection = this.connection;
                //se indica el tipo de comando
                this.command.CommandType = CommandType.StoredProcedure;
                //se indica el nombre del procedimiento almacenado 
                this.command.CommandText = "[Sp_Cns_InfractorPorNombre]";
                //asignamos el valor al parametro del procedimiento
                this.command.Parameters.AddWithValue("@NombreResponsable", pNombre);
                //se instancia un adaptador
                this.adapter = new SqlDataAdapter();
                //se instancia el comando al adaptador
                this.adapter.SelectCommand = this.command;
                //se instancia un dataset con los datos del comando
                this.dataset = new DataSet();
                //se llena el data set con los datos del comando
                this.adapter.Fill(this.dataset);
                //se cierran los recursos
                this.connection.Close();
                //se liberan los recursosr
                this.connection.Dispose();
                this.command.Dispose();
                this.adapter.Dispose();

                //se retorna el DataSet
                return this.dataset;
            }

            catch (Exception ex)
            {

                throw;
            }
        }
    }//fin de la clase
}//fin del namespace
