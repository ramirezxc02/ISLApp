using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ISLApp.Properties;

namespace ISLApp
{
    public partial class FrmPrincipal : Form
    {
        FrmInformeInfractor frmInforme;
        FrmUsuario frmUsuario;
        private Form activeForm = null;


        public FrmPrincipal()
        {
            InitializeComponent();
            

        }

        public static String getStringConexion()
        {
            return Settings.Default.StrConexion;
        }

        public void abrirFormularioHijo(Form formularioHijo)
        {
            if (activeForm != null)
                    activeForm.Close();
                    activeForm = formularioHijo;
                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;
                    panelPrincipal.Controls.Add(formularioHijo);
                    panelPrincipal.Tag = formularioHijo;
                    formularioHijo.BringToFront();
                    formularioHijo.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frmInforme != null)
            {
                frmInforme.Dispose();
                frmInforme = null;
            }
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.ShowDialog();
            frmReporte.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnCrearInforme_Click(object sender, EventArgs e)
        {

            if (frmInforme == null)
            {
                frmInforme = new FrmInformeInfractor();
                this.frmInforme.MdiParent = this;
                this.frmInforme.Show();
            }
            else { 
                frmInforme.Activate();
            }
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            if (frmInforme != null){
                frmInforme.Dispose();
                frmInforme=null;
            }
            frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }


        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Warning",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (boton == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.abrirFormularioHijo(new FrmInformeInfractor());

        }

        private void iconButtonReporte_Click(object sender, EventArgs e)
        {
            this.abrirFormularioHijo(new FrmReporte());

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (frmInforme != null)
            {
                frmInforme.Dispose();
                frmInforme = null;
            }
            frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void iconButtonUsuario_Click(object sender, EventArgs e)
        {
            this.abrirFormularioHijo(new FrmUsuario());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Warning",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (boton == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
