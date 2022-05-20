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
       int  idReporteModificar;


        public FrmReporte()
        {
            InitializeComponent();

            this.conexion = new Conexion(FrmPrincipal.ObtenerStringConexion());

            reporte = new Reporte();
        }

        public void registrarReporte(Reporte reporte)
        {
            conexion.RegistrarReporte(reporte);
           
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.BuscarReporte();
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarReporte frmAgregarReporte = new FrmAgregarReporte();
            frmAgregarReporte.ShowDialog();
            frmAgregarReporte.Close();
        }

        private void BuscarReporte()
        {
            try
            {
                this.dataGridDatos.DataSource = this.conexion.BuscarReporte(this.textBoxBuscarReporte.Text.Trim()).Tables[0];
                this.dataGridDatos.AutoResizeColumns();
                this.dataGridDatos.ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MostrarReporte()
        {
            try
            {
                this.dataGridDatos.DataSource = this.conexion.MostrarReporte().Tables[0];
                this.dataGridDatos.AutoResizeColumns();
                this.dataGridDatos.ReadOnly = true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.MostrarReporte();
        }

        private void FrmReporte_Activated(object sender, EventArgs e)
        {
            this.MostrarReporte();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAgregarReporte frmAgregarReporte = new FrmAgregarReporte();
            frmAgregarReporte.buttonAcciones.Text = "Modificar";
            frmAgregarReporte.labelIDReporte.Visible = true;
            frmAgregarReporte.textBoxIDreporte.Visible = true;

            this.reporte = this.conexion.BuscarReportePorIDReporte(idReporteModificar);


            frmAgregarReporte.textBoxIDInfractor.Text = reporte.idInfractor.ToString();
            frmAgregarReporte.textBoxCentroOperativo.Text = reporte.centroOperativo.ToString();
            frmAgregarReporte.textBoxCodigoPresupuestario.Text = reporte.codigoPresupuestario.ToString();
            frmAgregarReporte.textBoxActividad.Text = reporte.accionDesarrollada.ToString();
            frmAgregarReporte.textBoxViatico.Text = reporte.viatico.ToString();
            frmAgregarReporte.textBoxCombustible.Text = reporte.combustible.ToString();
            frmAgregarReporte.textBoxLugaresRecorridos.Text = reporte.lugaresRecorridos.ToString();
            frmAgregarReporte.textBoxRecomendacion.Text = reporte.recomendacion.ToString();
            frmAgregarReporte.textBoxObservacion.Text = reporte.observacion.ToString();
            frmAgregarReporte.textBoxMatricula.Text = reporte.matricula.ToString();
            frmAgregarReporte.textBoxKmInicial.Text = reporte.kilometroInicio.ToString();
            frmAgregarReporte.textBoxKmFinal.Text = reporte.kilometroFinal.ToString();
            frmAgregarReporte.textBoxPlaca.Text = reporte.placa.ToString();
             frmAgregarReporte.textBoxNumeroOficio.Text = reporte.numeroOficio.ToString();
            frmAgregarReporte.textBoxIDreporte.Text = reporte.idReporte.ToString();


            frmAgregarReporte.ShowDialog();
            frmAgregarReporte.Close();

        }


        public void dataGridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            idReporteModificar = int.Parse(this.dataGridDatos.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show( "entro");

        }
    }
}
