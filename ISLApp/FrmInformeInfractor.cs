using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISLApp
{
    public partial class FrmInformeInfractor : Form
    {
        private Conexion conexion;
        private string  nombre, cedula, tipo;
         int id= 0;
        public FrmInformeInfractor()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion()); // obtiene la conexion para la base de datos.
            //Pregunta si la conexion se logro realizar con la base de datos, si es satisfactoria el sistema continua con normalidad en caso contrario alerta al usuario (REQ).
            if (!conexion.realizarConexion()) {
                MessageBox.Show("No se logro establecer la conexión con la base de datos", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.cargarTabla();

            // Cambia el estado de los botones en caso de que los infractores sean igual que cero, el sistema no habilita los botones, en caso contrario se habilitaran para realizar una modificacion o eliminar.
            if (state() == 0)
            {
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
            else { 
                this.btnEditar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }


        private void FrmInformeInfractor_Load(object sender, EventArgs e)
        {
        }

        //Permite abrir la instancia de agregar un nuevo infractor.
        private void button1_Click(object sender, EventArgs e)
        {
            FrmInfractor infractor = new FrmInfractor(this);
            infractor.Show();
        }
        // Permite realizar consultas en la base de datos mediante los terminos escritos en el buscador, Argumentos para busqueda (id, nombre, cedula, tipo de infractor).
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.conexion.realizarConexion()) {

                    this.dgInfractores.DataSource = conexion.busqueda(txtBusqueda.Text);
                    this.dgInfractores.ReadOnly = true;
                }
                else {
                    MessageBox.Show("Se encontro un error: Error en la conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Se encontro un error: Error en la conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo que permite realizar una consulta de update a la base de datos para editar los datos de un infractor. requiere datos de infractor mediante el contentClick (Req)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    if (this.conexion.realizarConexion())
                    {
                        FrmInfractor modificarInfractor = new FrmInfractor(this, true, cedula, nombre, tipo, id);
                        modificarInfractor.Show();
                    }
                    else {
                        MessageBox.Show("Revise la conexión con internet o su conexión con la base de datos", "No se encontro la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Debe seleccionar un dato valido", "Datos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ocurrio un problema al seleccionar los datos","Error al seleccionar los datos",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Metodo en cargado de realizar una consulta a la base de datos para obtener todos los infractores activos en la base de datos.
        public void cargarTabla() {
            try
            {
                if (this.conexion.realizarConexion())
                {
                    this.dgInfractores.DataSource = conexion.consultaInfractores();
                    this.dgInfractores.ReadOnly = true;
                }
                else {
                    MessageBox.Show("Revise la conexión con internet o su conexión con la base de datos", "No se encontro la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo que llama al objecto conexion para enviar una consulta de delete, debe obtener previamente los datos del infractor que desea eliminar (REQ).
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0) {
                    if (this.conexion.realizarConexion())
                    {
                        conexion.deshabilitar(id);
                        MessageBox.Show("Se ha eliminado de manera correcta", "Proceso realizado de manera correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cargarTabla();
                    }
                    else {
                        MessageBox.Show("Revise la conexión con internet o su conexión con la base de datos", "No se encontro la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar a un infractor", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error" + ex);
                MessageBox.Show("Se encontro un error: Error de base datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Metodo que obtiene los valores de los infractores establecidos en la datagridview
        private void dgInfractores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dgInfractores.CurrentRow.Cells[0].Value.ToString());
                nombre = dgInfractores.CurrentRow.Cells[1].Value.ToString();
                cedula = dgInfractores.CurrentRow.Cells[2].Value.ToString();
                tipo = dgInfractores.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                id = 0;
                nombre = "";
                cedula = "";
                tipo = "";
                Console.WriteLine(ex.Message);
                MessageBox.Show("Debe seleccionar una casilla con datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Metodo que determina el estado que tendran los botones segun sea la cantidad de infractores.
        private  int  state()
        {
            try
            {
                int cantidad = 0;

                if (this.conexion.realizarConexion()) { 
                    cantidad = conexion.cantidadInfractoresActivos();
                }

                return cantidad;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problema con la base de datos" + ex);
                MessageBox.Show("Revise la conexión con internet o su conexión con la base de datos", "No se encontro la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        //Metodo que activa los botones de editar y modificar si la cantidad de infractores registrados activos son mayores a 0
        public void activarBotones()
        {
            this.btnEliminar.Enabled = true;
            this.btnEditar.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void dgInfractores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}