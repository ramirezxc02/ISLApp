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
        public int valor = 0;
        int idReporteModificar = 0;
        public FrmAgregarReporte()
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion());

            dateTimeHoraInicio.Format = DateTimePickerFormat.Custom;
            dateTimeHoraFinal.Format = DateTimePickerFormat.Custom;
            dateTimeHoraInicio.CustomFormat = "HH:mm";
            dateTimeHoraFinal.CustomFormat = "HH:mm";

            string fechaActual = DateTime.Now.ToString();
            string fechaReporte = dateTimeFechaReporte.Value.ToString();

            this.textBoxIDreporte.Text = this.conexion.numeroReporte().ToString();

        }

        //valida y hace el llamado a la base de datos para registrar un reporte
        public void registrarReporte()
        {
            try
            {
                if (this.validarEspaciosEnBlanco())
                {
                    this.conexion.registrarReporte(crearReporte());
                    MessageBox.Show("Reporte registrado correctamente.", "Proceso aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpiarTexBox();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //limpia los espacios despues de agregar en el frm agregar reporte
        public void limpiarTexBox()
        {
            this.textBoxIDInfractor.Text = "";
            this.textBoxCentroOperativo.Text = "";
            this.textBoxCodigoPresupuestario.Text = "";
            this.textBoxViatico.Text = "";
            this.textBoxNumeroOficio.Text = "";
            this.textBoxActividad.Text = "";
            this.textBoxRecomendacion.Text = "";
            this.textBoxObservacion.Text = "";
            this.textBoxMatricula.Text = "";
            this.textBoxCombustible.Text = "";
            this.textBoxKmInicial.Text = "";
            this.textBoxKmFinal.Text = "";
            this.textBoxPlaca.Text = "";
            this.textBoxNumFuncionariosSINAC.Text = "";
            this.textBoxNumFuncionariosOtrasInstituciones.Text = "";
            this.checkBoxNorte.Checked = false;
            this.checkBoxSur.Checked = false;
            this.checkBoxEste.Checked = false;
            this.checkBoxOeste.Checked = false;

        }

        //trae los valores y crea el obj reporte
        public Reporte crearReporte()
        {

            reporte = new Reporte();
            reporte.idReporte = int.Parse(this.textBoxIDreporte.Text.Trim());
            reporte.idInfractor = int.Parse(this.textBoxIDInfractor.Text.Trim());
            reporte.funcionarioResponsable = "Fabiana";
            reporte.centroOperativo = this.textBoxCentroOperativo.Text.Trim();
            reporte.codigoPresupuestario = this.textBoxCodigoPresupuestario.Text.Trim();
            reporte.viatico = int.Parse(this.textBoxViatico.Text.Trim());
            reporte.horaInicio = this.dateTimeHoraInicio.Value.ToString("HH:mm");
            reporte.lugaresRecorridos = validarCheckbox();
            reporte.horaFinalizacion = this.dateTimeHoraFinal.Value.ToString("HH:mm");
            reporte.fechaReporte = this.dateTimeFechaReporte.Text.Trim();
            reporte.numeroOficio = this.textBoxNumeroOficio.Text.Trim();
            reporte.accionDesarrollada = this.textBoxActividad.Text.Trim();
            reporte.recomendacion = this.textBoxRecomendacion.Text.Trim();
            reporte.observacion = this.textBoxObservacion.Text.Trim();
            reporte.matricula = this.textBoxMatricula.Text.Trim();
            reporte.combustible = int.Parse(this.textBoxCombustible.Text.Trim());
            reporte.kilometroInicio = this.textBoxKmInicial.Text.Trim();
            reporte.kilometroFinal = this.textBoxKmFinal.Text.Trim();
            reporte.placa = this.textBoxPlaca.Text.Trim();
            reporte.numeroFuncionariosSINAC = int.Parse(this.textBoxNumFuncionariosSINAC.Text.Trim());
            reporte.numeroFuncionariosOtrasInstituciones = int.Parse(this.textBoxNumFuncionariosOtrasInstituciones.Text.Trim());
            reporte.estado = 1;

            return reporte;
        }

        //valida y hace el llamado a la base de datos para modificar un reporte
        public void modificarReporte()
        {
            try
            {
                if (this.validarEspaciosEnBlanco())
                {
                    this.conexion.modificarReporte(crearReporte());
                    MessageBox.Show("Reporte actualizado correctamente.", "Proceso aplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            idReporteModificar = 0;
        }

        //valida la opcion que eligio el usuario en el checkbox
        public string validarCheckbox()
        {
            string lugaresRecorridos = "";

            if (this.checkBoxNorte.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(lugaresRecorridos))
                {
                    lugaresRecorridos = lugaresRecorridos + " , " + this.checkBoxNorte.Text.Trim();
                }
                else
                {
                    lugaresRecorridos = this.checkBoxNorte.Text.Trim();
                }
            }
            if (this.checkBoxSur.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(lugaresRecorridos))
                {
                    lugaresRecorridos = lugaresRecorridos + " , " + this.checkBoxSur.Text.Trim();
                }
                else
                {
                    lugaresRecorridos = this.checkBoxSur.Text.Trim();
                }
            }
            if (this.checkBoxEste.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(lugaresRecorridos))
                {
                    lugaresRecorridos = lugaresRecorridos + " , " + this.checkBoxEste.Text.Trim();
                }
                else
                {
                    lugaresRecorridos = this.checkBoxEste.Text.Trim();
                }

            }
            if (this.checkBoxOeste.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(lugaresRecorridos))
                {
                    lugaresRecorridos = lugaresRecorridos + " , " + this.checkBoxOeste.Text.Trim();
                }
                else
                {
                    lugaresRecorridos = this.checkBoxOeste.Text.Trim();
                }
            }
            return lugaresRecorridos;
        }


        //verifica si el usuario eligio un registro en la tabla para modificar, si eligio un registro el valor es 1 y puede modificar sino es 0 y puede registrar un reporte
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.valor == 1)
            {
                this.modificarReporte();
            }
            else
            {
                this.registrarReporte();
            }
        }

        //verificar los input en blanco a la hora de presion Guradar reporte
        private bool validarEspaciosEnBlanco()
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
            if (dateTimeFechaReporte.Value.Date > DateTime.Now)
            {
                MessageBox.Show("La fecha seleccionada no debe ser mayor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                esValido = false;
            }

            return esValido;

        }

        //verifica que algunos inputs solo pueden ibnresar numeros y otros letras
        private void validarNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede digitar números en este espacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }
        private void textBoxPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validarNumeros(e);
        }

        private void textBoxNumFuncionariosSINAC_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validarNumeros(e);
        }

        private void textBoxNumFuncionariosOtrasInstituciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.validarNumeros(e);
        }

        private void FrmAgregarReporte_Load(object sender, EventArgs e)
        {
            //esta línea de código carga datos en la tabla 'islaSanLucasBDDataSet.Infractor' 
            //this.infractorTableAdapter.Fill(this.islaSanLucasBDDataSet.Infractor);

        }

        private void pbProd_Click(object sender, EventArgs e)
        {
            this.mostrarVerInfrac();
        }

        public void mostrarVerInfrac()
        {
            FrmVerInfractor frm = new FrmVerInfractor();
            //mostrar formulario
            frm.ShowDialog(this);
            //liberamos los recursos de memoria
            frm.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonBuscarIDInfractor_Click(object sender, EventArgs e)
        {
            this.mostrarVerInfrac();

        }
    }
}
