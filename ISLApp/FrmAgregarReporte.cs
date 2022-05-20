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
    public partial class FrmAgregarReporte : Form
    {
        Conexion conexion;
        Reporte reporte;

        public FrmAgregarReporte()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.ObtenerStringConexion());

        }

        public void registrarReporte()
        {
            try
            {
                if (this.ValidarEspaciosEnBlanco())
                { 
                    this.conexion.RegistrarReporte(crearReporte());
                    MessageBox.Show("Reporte registrado correctamente.", "Proceso aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Reporte crearReporte()
        {

            //this.ValidacionesDatosRequeridos();

            reporte = new Reporte();

            reporte.idInfractor =  int.Parse(this.textBoxIDInfractor.Text.Trim());
            reporte.funcionarioResponsable = "Fabiana";
            reporte.centroOperativo = this.textBoxCentroOperativo.Text.Trim();
            reporte.codigoPresupuestario = this.textBoxCodigoPresupuestario.Text.Trim();
            reporte.viatico = int.Parse(this.textBoxViatico.Text.Trim()); //VIATICO
            reporte.horaInicio = this.dateTimeHoraInicio.Value.ToString("hh:mm:ss");
            reporte.lugaresRecorridos = this.textBoxLugaresRecorridos.Text.Trim();
            reporte.horaFinalizacion = this.dateTimeHoraFinal.Value.ToString("hh:mm:ss");
            reporte.numeroOficio = this.textBoxNumeroOficio.Text.Trim();
            reporte.accionDesarrollada = this.textBoxActividad.Text.Trim();
            reporte.fechaReporte = this.dateTimeFechaReporte.Value.ToString("MM/dd/yyyy");
            reporte.recomendacion = this.textBoxRecomendacion.Text.Trim();
            reporte.observacion = this.textBoxObservacion.Text.Trim();
            reporte.matricula = this.textBoxMatricula.Text.Trim();
            reporte.combustible = int.Parse(this.textBoxCombustible.Text.Trim());
            reporte.kilometroInicio = this.textBoxKmInicial.Text.Trim();
            reporte.kilometroFinal = this.textBoxKmFinal.Text.Trim(); 
            reporte.placa = this.textBoxPlaca.Text.Trim();
            reporte.estado = 1;
          
          
            return reporte;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.registrarReporte();
        }

        private void textBoxObservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarEspaciosEnBlanco()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(this.textBoxNumeroOficio.Text.Trim()))
            {
                MessageBox.Show("El espacio número de oficio no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxIDInfractor.Text.Trim()))
            {
                MessageBox.Show("El espacio id infractor no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxCentroOperativo.Text.Trim()))
            {
                MessageBox.Show("El espacio centro operativo no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxActividad.Text.Trim()))
            {
                MessageBox.Show("El espacio actividad no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxCodigoPresupuestario.Text.Trim()))
            {
                MessageBox.Show("El espacio código presupuestario no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.dateTimeHoraInicio.Text.Trim()))
            {
                MessageBox.Show("El espacio hora de inicio no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.dateTimeHoraFinal.Text.Trim()))
            {
                MessageBox.Show("El espacio hora de finalización no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxMatricula.Text.Trim()))
            {
                MessageBox.Show("El espacio matrícula no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxLugaresRecorridos.Text.Trim()))
            {
                MessageBox.Show("El espacio lugares recorridos no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxViatico.Text.Trim()))
            {
                MessageBox.Show("El espacio viático no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxKmInicial.Text.Trim()))
            {
                MessageBox.Show("El espacio km inicial no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxKmFinal.Text.Trim()))
            {
                MessageBox.Show("El espacio km final no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxRecomendacion.Text.Trim()))
            {
                MessageBox.Show("El espacio recomendación no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxObservacion.Text.Trim()))
            {
                MessageBox.Show("El espacio observación no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(this.textBoxPlaca.Text.Trim()))
            {
                MessageBox.Show("El espacio placa no puede ser vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }
            return esValido;

        }

        private void FrmAgregarReporte_Load(object sender, EventArgs e)
        {

        }
    }
}
