using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;
using BLL;

namespace ISLApp
{
    public partial class FrmReporte : Form
    {
        public Conexion conexion;
        public Reporte reporte;
        int idReporteModificar;
        int valor = 0;


        public FrmReporte()
        {
            InitializeComponent();

            this.conexion = new Conexion(FrmPrincipal.getStringConexion());
;
            reporte = new Reporte();
           
        }

        //establece la conexion con la base de datos
        public void registrarReporte(Reporte reporte)
        {
            conexion.registrarReporte(reporte);
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.buscarReporte();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //muestra el frm de agregar reporte
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarReporte frmAgregarReporte = new FrmAgregarReporte();
            frmAgregarReporte.ShowDialog();
            frmAgregarReporte.Close();
            this.mostrarReporte();
        }

        
        private void buscarReporte()
        {
            try
            {
                this.dataGridDatos.DataSource = this.conexion.buscarReporte(this.textBoxBuscarReporte.Text.Trim()).Tables[0];
                this.dataGridDatos.AutoResizeColumns();
                this.dataGridDatos.ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //muestra los reportes registrados en la base de datos en la tabla
        public void mostrarReporte()
        {
            try
            {
                this.dataGridDatos.DataSource = this.conexion.mostrarReporte().Tables[0];
                this.dataGridDatos.AutoResizeColumns();
                this.dataGridDatos.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.mostrarReporte();
        }

       

        private void FrmReporte_Activated(object sender, EventArgs e)
        {
           
        }


        //si el usuario elige un registro en la tabla el valor pasa a ser 1
        //esta funcion muestra el frm para modificar y muestra los datos del registro elegido
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idReporteModificar != 0)
            {
                if (valor == 1)
                {

                    try
                    {
                        FrmAgregarReporte frmAgregarReporte = new FrmAgregarReporte();
                        frmAgregarReporte.buttonAcciones.Text = "MODIFICAR";
               
                        frmAgregarReporte.valor = 1;


                        this.reporte = this.conexion.buscarReportePorIDReporte(idReporteModificar);

                        frmAgregarReporte.textBoxIDreporte.Text = reporte.idReporte.ToString();
                        frmAgregarReporte.textBoxIDInfractor.Text = reporte.idInfractor.ToString();
                        frmAgregarReporte.textBoxCentroOperativo.Text = reporte.centroOperativo.ToString();
                        frmAgregarReporte.textBoxCodigoPresupuestario.Text = reporte.codigoPresupuestario.ToString();
                        frmAgregarReporte.textBoxViatico.Text = reporte.viatico.ToString();
                        frmAgregarReporte.dateTimeHoraInicio.Value = DateTime.Parse(reporte.horaInicio);
                        frmAgregarReporte.dateTimeHoraFinal.Value = DateTime.Parse(reporte.horaFinalizacion);
                        frmAgregarReporte.textBoxNumeroOficio.Text = reporte.numeroOficio.ToString();
                        frmAgregarReporte.textBoxActividad.Text = reporte.accionDesarrollada.ToString();
                        frmAgregarReporte.dateTimeFechaReporte.Value = DateTime.Parse(reporte.fechaReporte);
                        frmAgregarReporte.textBoxRecomendacion.Text = reporte.recomendacion.ToString();
                        frmAgregarReporte.textBoxObservacion.Text = reporte.observacion.ToString();
                        frmAgregarReporte.textBoxMatricula.Text = reporte.matricula.ToString();
                        frmAgregarReporte.textBoxCombustible.Text = reporte.combustible.ToString();
                        frmAgregarReporte.textBoxKmInicial.Text = reporte.kilometroInicio.ToString();
                        frmAgregarReporte.textBoxKmFinal.Text = reporte.kilometroFinal.ToString();
                        frmAgregarReporte.textBoxPlaca.Text = reporte.placa.ToString();
                        frmAgregarReporte.textBoxNumFuncionariosSINAC.Text = reporte.numeroFuncionariosSINAC.ToString();
                        frmAgregarReporte.textBoxNumFuncionariosOtrasInstituciones.Text = reporte.numeroFuncionariosOtrasInstituciones.ToString();


                        frmAgregarReporte.ShowDialog();
                        idReporteModificar = 0;
                        frmAgregarReporte.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        Console.WriteLine(ex);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Debe seleccionar una casilla con datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.mostrarReporte();
        }

        //si el usuario elige un reporte en el tabla el valor pasa a ser 1
        private void dataGridDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                idReporteModificar = int.Parse(this.dataGridDatos.CurrentRow.Cells[0].Value.ToString());
                valor = 1;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //si el usuario elige un registro en la tabla el valor pasa a ser 1
        //esta funcion muestra un mensaje de confirmacion para eliminar y elimina el reporte
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(idReporteModificar != 0)
            {
                if (valor == 1)
                {

                    try
                    {
                        DialogResult boton = MessageBox.Show("¿Está seguro que desea eliminar este reporte?", "Warning",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (boton == DialogResult.OK)
                        {
                            this.conexion.deshabilitarReporte(idReporteModificar);
                            MessageBox.Show("Reporte eliminado correctamente.", "Proceso aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una casilla con datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.mostrarReporte();

        }

       
    }
}
